using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Threading.Tasks;

namespace DireCrypt
{
    public class AES
    {
        private static bool isReadOnly = false;
        private static FileInfo beforeFile = null;

        public static long DecryptFile(string FilePath, string Password, byte[] passHash)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            int len;
            byte[] buffer = new byte[4096];
            string OutFilePath = Path.Combine(Path.GetDirectoryName(FilePath), Path.GetFileNameWithoutExtension(FilePath));
            releaseReadOnly(FilePath);


            List<byte> readPass = new List<byte>();
            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite))
            {
                for (long offset = fs.Length - 64; offset < fs.Length; offset++)
                {
                    fs.Seek(offset, SeekOrigin.Begin);
                    readPass.Add((byte)fs.ReadByte());
                }
                if (!readPass.SequenceEqual(passHash)) return -1;
                fs.SetLength(fs.Length - 64);
            }
            
            
            using (FileStream outfs = new FileStream(OutFilePath, FileMode.Create, FileAccess.Write))
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (AesManaged aes = new AesManaged())
                    {
                        aes.BlockSize = 128;              // BlockSize = 16bytes
                        aes.KeySize = 128;                // KeySize = 16bytes
                        aes.Mode = CipherMode.CBC;        // CBC mode
                        aes.Padding = PaddingMode.PKCS7;    // Padding mode is "PKCS7".

                        // salt
                        byte[] salt = new byte[16];
                        fs.Read(salt, 0, 16);
                        // Initilization Vector
                        byte[] iv = new byte[16];
                        fs.Read(iv, 0, 16);
                        aes.IV = iv;

                        // ivをsaltにしてパスワードを擬似乱数に変換
                        Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(Password, salt);
                        byte[] bufferKey = deriveBytes.GetBytes(16);    // 16バイトのsaltを切り出してパスワードに変換
                        aes.Key = bufferKey;

                        //Decryption interface.
                        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                        using (CryptoStream cse = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                        {
                            using (DeflateStream ds = new DeflateStream(cse, CompressionMode.Decompress))   //解凍
                            {
                                while ((len = ds.Read(buffer, 0, 4096)) > 0)
                                    outfs.Write(buffer, 0, len);
                            }
                        }
                    }
                }
            }

            copyFileInfoForm_FilePath(OutFilePath);
            File.Delete(FilePath);
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }


        public static long EncryptFile(string FilePath, string Password, byte[] passHash)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            int len;
            byte[] buffer = new byte[4096];

            //Output file path.
            string OutFilePath = Path.Combine(Path.GetDirectoryName(FilePath), Path.GetFileName(FilePath)) + ".dcrpt";
            releaseReadOnly(FilePath);

            using (FileStream outfs = new FileStream(OutFilePath, FileMode.Create, FileAccess.Write))
            {
                using (AesManaged aes = new AesManaged())
                {
                    aes.BlockSize = 128;              // BlockSize = 16bytes
                    aes.KeySize = 128;                // KeySize = 16bytes
                    aes.Mode = CipherMode.CBC;        // CBC mode
                    aes.Padding = PaddingMode.PKCS7;    // Padding mode is "PKCS7".

                    //入力されたパスワードをベースに擬似乱数を新たに生成
                    Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(Password, 16);
                    byte[] salt = new byte[16]; // Rfc2898DeriveBytesが内部生成したなソルトを取得
                    salt = deriveBytes.Salt;
                    // 生成した擬似乱数から16バイト切り出したデータをパスワードにする
                    byte[] bufferKey = deriveBytes.GetBytes(16);
                    aes.Key = bufferKey;
                    aes.GenerateIV();

                    //Encryption interface.
                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (CryptoStream cse = new CryptoStream(outfs, encryptor, CryptoStreamMode.Write))
                    {
                        outfs.Write(salt, 0, 16);     // salt をファイル先頭に埋め込む
                        outfs.Write(aes.IV, 0, 16); // 次にIVもファイルに埋め込む
                        using (DeflateStream ds = new DeflateStream(cse, CompressionMode.Compress)) //圧縮
                        {
                            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                            {
                                while ((len = fs.Read(buffer, 0, 4096)) > 0)
                                {
                                    ds.Write(buffer, 0, len);
                                }
                            }
                        }
                    }
                }
            }
            
            
            using (FileStream fs = new FileStream(OutFilePath, FileMode.Append, FileAccess.Write))
            {
                fs.Write(passHash, 0, passHash.Length);
            }
            
            copyFileInfoForm_FilePath(OutFilePath);
            File.Delete(FilePath);
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public static byte[] GetSHA512ByPassword(string password)
        {
            byte[] byteValue = Encoding.UTF8.GetBytes(password);
            var crypto = new SHA512Managed();
            return crypto.ComputeHash(byteValue);
        }

        public static string BytesToString(byte[] bytesData)
        {
            StringBuilder hashedText = new StringBuilder();
            for (int i = 0; i < bytesData.Length; i++)
            {
                hashedText.AppendFormat("{0:X2}", bytesData[i]);
            }
            return hashedText.ToString();
        }

        private static void releaseReadOnly(string FilePath)
        {
            beforeFile = new FileInfo(FilePath);
            isReadOnly = ((beforeFile.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);            
            if (isReadOnly) beforeFile.Attributes &= ~FileAttributes.ReadOnly;
        }

        private static void copyFileInfoForm_FilePath(string OutFilePath)
        {
            FileInfo afterFile = new FileInfo(OutFilePath);
            afterFile.Attributes = beforeFile.Attributes;
            afterFile.CreationTime = beforeFile.CreationTime;
            afterFile.LastWriteTime = beforeFile.LastWriteTime;
            afterFile.LastAccessTime = beforeFile.LastAccessTime;
            if (isReadOnly) afterFile.Attributes |= FileAttributes.ReadOnly;
            beforeFile = null;
            afterFile = null;
        }
    }
}
