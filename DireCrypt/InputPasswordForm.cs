using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DireCrypt
{
    public partial class InputPasswordForm : Form
    {
        public InputPasswordForm()
        {
            InitializeComponent();
        }

        public string Password { get; set; } = "";
        public bool CancelFlag { get; set; } = false;

        private void InputPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void mainDecision_button_Click(object sender, EventArgs e)
        {
            if (mainInputPassword_textBox.Text == "")
            {
                MessageBox.Show("パスワードを入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Password = mainInputPassword_textBox.Text;
                Close();
            }
        }

        private void mainShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mainShowPassword_checkBox.Checked)
                mainInputPassword_textBox.PasswordChar = '\0';          
            else
                mainInputPassword_textBox.PasswordChar = char.Parse("●");
        }

        private void mainInputPassword_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                mainDecision_button_Click(null, EventArgs.Empty);
        }

        private void mainCancel_button_Click(object sender, EventArgs e)
        {
            CancelFlag = true;
            Close();
        }

        private void InputPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Password == "")
                CancelFlag = true;
        }
    }
}
