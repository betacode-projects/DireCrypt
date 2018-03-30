using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DireCrypt
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public string FilePath { get; set; } = "";
        public bool IsDirectory { get; set; } = false;
        public bool IsEncryption { get; set; } = true;

        private void ProgressForm_Load(object sender, EventArgs e)
        {

        }

        private void ProgressForm_Shown(object sender, EventArgs e)
        {
            if (IsEncryption)
                startEncryption();
            else
                startDecryption();
        }


        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(
            HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0x000B;

        /// <summary>
        /// コントロールの再描画を停止させる
        /// </summary>
        /// <param name="control">対象のコントロール</param>
        private static void beginControlUpdate(Control control)
        {
            SendMessage(new HandleRef(control, control.Handle),
                WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// コントロールの再描画を再開させる
        /// </summary>
        /// <param name="control">対象のコントロール</param>
        private static void endControlUpdate(Control control)
        {
            SendMessage(new HandleRef(control, control.Handle),
                WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
            control.Invalidate();
        }


        private void startEncryption()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            Text = "DireCrypt - ファイルを暗号化中...";
            mainStatus_textBox.AppendText("[*] Setting encryption password...");

            var passInput = new SetPasswordForm();
            Task task = null;
            long error = 0;

            passInput.ShowDialog();
            string password = passInput.Password;
            byte[] passHash = AES.GetSHA512ByPassword(password);
            if (passInput.CancelFlag)
            {
                mainStatus_textBox.AppendText("\r\n\r\n[+] Canceled file encryption.");
                Text = "DireCrypt - ファイル暗号化キャンセル";
                closeButtonActive();
                return;
            }
            passInput.Dispose();
            GC.Collect();
            mainStatus_textBox.AppendText("\r\n[+] Set password: "+ new String('*', password.Length) +" ("+ AES.BytesToString(passHash) +")");

            if (IsDirectory)
            {
                mainStatus_textBox.AppendText("\r\n[*] Getting '" + FilePath + "' files...");
                List<string> files = getDirectoryFiles();
                main_ProgressBar.Maximum = files.Count;
                mainStatus_textBox.AppendText("\r\n[+] Got '" + FilePath + "' files: " + files.Count.ToString());
                mainStatus_textBox.AppendText("\r\n\r\n[+] Starting encrypted files...\r\n\r\n");

                task = Task.Factory.StartNew(() =>
                {                   
                    foreach (string file in files)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            try
                            {
                                main_ProgressBar.Value += 1;
                                long time_ms = AES.EncryptFile(file, password, passHash);
                                mainStatus_textBox.AppendText("[+] Encrypted (" + time_ms.ToString() + "ms): " + file + "\r\n");
                            }
                            catch (Exception ex)
                            {
                                error++;
                                mainStatus_textBox.AppendText("[-] " + ex.Message + ": " + file + "\r\n");
                                deleteFileAncys(Path.Combine(Path.GetDirectoryName(FilePath), Path.GetFileName(FilePath)) + ".dcrpt");
                            }
                        });
                    }
                    files = null;
                });
            }
            else
            {
                mainStatus_textBox.AppendText("\r\n[+] Starting encrypted files...\r\n\r\n");
                task = Task.Factory.StartNew(() =>
               {
                   try
                   {
                       main_ProgressBar.Maximum = 1;
                       mainStatus_textBox.AppendText("[+] Encrypting: " + FilePath + "\r\n");
                       AES.EncryptFile(FilePath, password, passHash);
                   }
                   catch (Exception ex)
                   {
                       error++;
                       mainStatus_textBox.AppendText("[-] Failed: " + FilePath + " | " + ex.ToString() + "\r\n");
                       deleteFileAncys(Path.Combine(Path.GetDirectoryName(FilePath), Path.GetFileName(FilePath)) + ".dcrpt");
                   }
               });
            }

            Task.Factory.StartNew(() =>
            {         
                if (task != null) task.Wait();
                sw.Stop();
                Text = "DireCrypt - ファイル暗号化完了";
                mainStatus_textBox.AppendText("\r\n[*] Time: " + sw.Elapsed.ToString() + " | Success: " + (main_ProgressBar.Maximum - error).ToString() + "/" + main_ProgressBar.Maximum.ToString() + " | Error: " + error.ToString() +"/"+ main_ProgressBar.Maximum.ToString());
                mainStatus_textBox.AppendText("\r\n[+] Finished file encryption.");
                closeButtonActive();
            });
        }

        private List<string> getDirectoryFiles(string filter = "*")
        {
            IEnumerable<string> files = Directory.EnumerateFiles(FilePath, filter, SearchOption.AllDirectories);
            return files.ToList();
        }

        private void startDecryption()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Text = "DireCrypt - ファイルを復号化中...";
            mainStatus_textBox.AppendText("[*] Setting decryption password...");

            var passInput = new InputPasswordForm();
            Task task = null;
            long error = 0;

            passInput.ShowDialog();
            string password = passInput.Password;
            byte[] passHash = AES.GetSHA512ByPassword(password);
            if (passInput.CancelFlag)
            {
                mainStatus_textBox.AppendText("\r\n\r\n[+] Canceled file decryption.");
                Text = "DireCrypt - ファイル復号化キャンセル";
                closeButtonActive();
                return;
            }

            passInput.Dispose();
            GC.Collect();
            mainStatus_textBox.AppendText("\r\n[+] Set password: " + new String('*', password.Length) + " (" + AES.BytesToString(passHash) + ")");

            if (IsDirectory)
            {
                mainStatus_textBox.AppendText("\r\n[*] Getting '" + FilePath + "' files...");
                List<string> files = getDirectoryFiles("*.dcrpt");
                main_ProgressBar.Maximum = files.Count;
                mainStatus_textBox.AppendText("\r\n[+] Got '" + FilePath + "' files: " + files.Count.ToString());
                mainStatus_textBox.AppendText("\r\n[+] Starting decrypted files...\r\n\r\n");

                task = Task.Factory.StartNew(() =>
                {
                    foreach (string file in files)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            try
                            {
                                main_ProgressBar.Value += 1;
                                long time_ms = AES.DecryptFile(file, password, passHash);
                                if (time_ms == -1)
                                {
                                    mainStatus_textBox.AppendText("[-] パスワードが一致しません: " + file + "\r\n");
                                    error++;
                                }
                                else
                                    mainStatus_textBox.AppendText("[+] Decrypted (" + time_ms.ToString() + "ms): " + file + "\r\n");
                            }
                            catch (Exception ex)
                            {
                                error++;
                                mainStatus_textBox.AppendText("[-] " + ex.Message + ": " + file + "\r\n");
                                deleteFileAncys(Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file)));
                            }
                        });
                    }
                    files = null;
                });
            }
            else
            {
                mainStatus_textBox.AppendText("\r\n[+] Starting encrypted files...\r\n\r\n");
                task = Task.Factory.StartNew(() =>
               {
                   try
                   {
                       main_ProgressBar.Maximum = 1;
                       mainStatus_textBox.AppendText("[+] Decrypting: " + FilePath + "\r\n");
                       AES.DecryptFile(FilePath, password, passHash);
                   }
                   catch (Exception ex)
                   {
                       error++;
                       mainStatus_textBox.AppendText("[-] Failed: " + FilePath + " | " + ex.ToString() + "\r\n");
                   }
               });
            }

            Task.Factory.StartNew(() =>
            {
                if (task != null) task.Wait();
                sw.Stop();
                Text = "DireCrypt - ファイル復号化完了";
                mainStatus_textBox.AppendText("\r\n[*] Time: " + sw.Elapsed.ToString() + " | Success: "+ (main_ProgressBar.Maximum - error).ToString() + "/"+ main_ProgressBar.Maximum.ToString()+" | Error: " + error.ToString() + "/" + main_ProgressBar.Maximum.ToString());
                mainStatus_textBox.AppendText("\r\n[+] Finished file decryption.");
                closeButtonActive();
            });
        }

        private void closeButtonActive()
        {
            main_ProgressBar.Maximum = 1;
            main_ProgressBar.Value = main_ProgressBar.Maximum;
            Console.Write("\a");
            mainClose_Button.Enabled = true;
            ActiveControl = mainClose_Button;
        }

        private static void deleteFileAncys(string stFilePath)
        {
            Task.Factory.StartNew(() =>
           {
                   FileInfo cFileInfo = new FileInfo(stFilePath);
                   if ((cFileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                       cFileInfo.Attributes = FileAttributes.Normal;
                   cFileInfo.Delete();
           });
        }

        private void mainClose_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainShow_button_Click(object sender, EventArgs e)
        {
            if (mainShow_button.Text == "更新")
            {
                endControlUpdate(mainStatus_textBox);
                mainShow_button.Text = "非更新";
            }
            else
            {
                beginControlUpdate(mainStatus_textBox);
                mainShow_button.Text = "更新";
            }
        }
    }
}
