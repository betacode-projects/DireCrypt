using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DireCrypt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private static string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string dirPath = Path.GetDirectoryName(appPath);

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(dirPath + @"\PathCache.inf"))
                {
                    string line = "";
                    int count = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isFileFolderExist(line))
                        {
                            if (!mainFilePath_comboBox.Items.Contains(line)) mainFilePath_comboBox.Items.Add(line);
                            if (count >= 30) break;
                            count++;
                        }
                    }
                    mainFilePath_comboBox.Text = (string)mainFilePath_comboBox.Items[0];
                }
            } catch { }
        }

        private void mainEncrypt_Panel_MouseEnter(object sender, EventArgs e)
        {
            mainEncrypt_Panel.BackColor = Color.LimeGreen;           
        }

        private void mainEncrypt_Panel_MouseLeave(object sender, EventArgs e)
        {
            mainEncrypt_Panel.BackColor = Color.PaleGreen;
        }

        private void mainDecrypt_panel_MouseEnter(object sender, EventArgs e)
        {
            mainDecrypt_Panel.BackColor = Color.IndianRed;       
        }

        private void mainDecrypt_panel_MouseLeave(object sender, EventArgs e)
        {
            mainDecrypt_Panel.BackColor = Color.LightCoral;
        }

        private void mainEncrypt_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mainEncrypt_Panel.BorderStyle = BorderStyle.Fixed3D;           
        }

        private void mainEncrypt_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            mainEncrypt_Panel.BorderStyle = BorderStyle.FixedSingle;
            startFileEncryption(true);
        }

        private void mainDecrypt_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mainDecrypt_Panel.BorderStyle = BorderStyle.Fixed3D;            
        }

        private void mainDecrypt_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            mainDecrypt_Panel.BorderStyle = BorderStyle.FixedSingle;
            startFileEncryption(false);
        }

        private void mainDirectoryShow_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                comboboxInsert(folderBrowserDialog.SelectedPath);
        }

        private void mainFileShow_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                comboboxInsert(openFileDialog.FileName);
        }

        private void comboboxInsert(string data)
        {
            if (!mainFilePath_comboBox.Items.Contains(data))
                mainFilePath_comboBox.Items.Insert(0, data);
            mainFilePath_comboBox.Text = data;
        }

        private bool isFileFolderExist(string path)
        {
            if (!File.Exists(path))
                if (!Directory.Exists(path))
                    return false;
            return true;
        }

        private bool checkSettings()
        {
            if (mainFilePath_comboBox.Text == "")
            {
                MessageBox.Show("ファイルまたはフォルダのパスを指定してください。", "ファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isFileFolderExist(mainFilePath_comboBox.Text))
            {
                MessageBox.Show("指定されたファイルまたはフォルダのパスは存在しません", "ファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                int index = mainFilePath_comboBox.SelectedIndex;
                mainFilePath_comboBox.Items.RemoveAt(index);
                return false;
            }

            return true;
        }

        private void startFileEncryption(bool isEncryption)
        {
            Task.Factory.StartNew(() =>
           {
               TopMost = false;
               Enabled = false;
               if (checkSettings())
               {
                   var progress = new ProgressForm();
                   progress.IsEncryption = isEncryption;
                   progress.FilePath = mainFilePath_comboBox.Text;
                   progress.IsDirectory = Directory.Exists(mainFilePath_comboBox.Text);
                   progress.ShowDialog();
               }
               TopMost = true;
               Enabled = true;
               GC.Collect();
           });
        }

        private void mainEncrypt_Panel_DragEnter(object sender, DragEventArgs e)
        {
            mainEncrypt_Panel.BorderStyle = BorderStyle.Fixed3D;
            mainEncrypt_Panel_MouseEnter(null, null);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mainEncrypt_Panel_DragDrop(object sender, DragEventArgs e)
        {
            mainEncrypt_Panel_MouseLeave(null, null);
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            comboboxInsert(fileName[0]);
            mainEncrypt_Panel_MouseUp(null, null);
        }

        private void mainDecrypt_Panel_DragEnter(object sender, DragEventArgs e)
        {
            mainDecrypt_Panel.BorderStyle = BorderStyle.Fixed3D;
            mainDecrypt_panel_MouseEnter(null, null);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mainDecrypt_Panel_DragDrop(object sender, DragEventArgs e)
        {
            mainDecrypt_panel_MouseLeave(null, null);
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            comboboxInsert(fileName[0]);
            mainDecrypt_Panel_MouseUp(null, null);
        }

        private void mainEncrypt_Panel_DragLeave(object sender, EventArgs e)
        {
            mainEncrypt_Panel_MouseLeave(null, null);
            mainEncrypt_Panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void mainDecrypt_Panel_DragLeave(object sender, EventArgs e)
        {
            mainDecrypt_panel_MouseLeave(null, null);
            mainDecrypt_Panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int count = 0;
                using (StreamWriter sw = new StreamWriter(dirPath + @"\PathCache.inf"))
                {
                    foreach (string path in mainFilePath_comboBox.Items)
                    {
                        if (isFileFolderExist(path))
                        {
                            sw.WriteLine(path);
                            if (count >= 30) break;
                            count++;
                        }
                    }
                }
            }
            catch { }
        }

        private int comboboxCount = 0;
        
        private void mainFilePath_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainShowPath_toolTip.SetToolTip(mainFilePath_comboBox, mainFilePath_comboBox.Text);
            if (comboboxCount == mainFilePath_comboBox.Items.Count)
            {              
                string data = mainFilePath_comboBox.Text;
                mainFilePath_comboBox.Items.RemoveAt(mainFilePath_comboBox.SelectedIndex);
                mainFilePath_comboBox.Items.Insert(0, data);
                mainFilePath_comboBox.SelectedIndexChanged -= mainFilePath_comboBox_SelectedIndexChanged;
                mainFilePath_comboBox.SelectedIndex = 0;
                mainFilePath_comboBox.SelectedIndexChanged += mainFilePath_comboBox_SelectedIndexChanged;
            }
            else
                comboboxCount = mainFilePath_comboBox.Items.Count;
        }

        private void mainDeletePath_button_Click(object sender, EventArgs e)
        {
            try
            {
                int index = mainFilePath_comboBox.SelectedIndex;
                mainFilePath_comboBox.Items.RemoveAt(index);
            } catch { }
        }
    }
}
