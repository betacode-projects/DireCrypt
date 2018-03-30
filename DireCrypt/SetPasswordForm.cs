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
    public partial class SetPasswordForm : Form
    {
        public SetPasswordForm()
        {
            InitializeComponent();
        }

        public string Password { get; set; } = "";
        public bool CancelFlag { get; set; } = false;

        private void SetPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Password == "")
                CancelFlag = true;
        }

        private void mainStart_button_Click(object sender, EventArgs e)
        {
            if (mainInput_textBox.Text == "")
            {
                MessageBox.Show("パスワードを入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (mainInput_textBox.Text == mainReInput_textBox.Text)
            {
                Password = mainInput_textBox.Text;
                Close();
            }
            else
            {
                MessageBox.Show("入力されたパスワードが一致しません。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mainCancel_button_Click(object sender, EventArgs e)
        {
            Password = "";
            Close();
        }

        private void mainInput_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                mainReInput_textBox.Focus();
        }

        private void mainReInput_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                mainStart_button_Click(null, EventArgs.Empty);
        }
    }
}
