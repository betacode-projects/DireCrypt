namespace DireCrypt
{
    partial class InputPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPasswordForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainShowPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.mainDecision_button = new System.Windows.Forms.Button();
            this.mainInputPassword_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainCancel_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainShowPassword_checkBox);
            this.groupBox1.Controls.Add(this.mainInputPassword_textBox);
            this.groupBox1.Location = new System.Drawing.Point(79, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "パスワードを入力してください";
            // 
            // mainShowPassword_checkBox
            // 
            this.mainShowPassword_checkBox.AutoSize = true;
            this.mainShowPassword_checkBox.Location = new System.Drawing.Point(6, 31);
            this.mainShowPassword_checkBox.Name = "mainShowPassword_checkBox";
            this.mainShowPassword_checkBox.Size = new System.Drawing.Size(15, 14);
            this.mainShowPassword_checkBox.TabIndex = 2;
            this.mainShowPassword_checkBox.UseVisualStyleBackColor = true;
            this.mainShowPassword_checkBox.CheckedChanged += new System.EventHandler(this.mainShowPassword_checkBox_CheckedChanged);
            // 
            // mainDecision_button
            // 
            this.mainDecision_button.Location = new System.Drawing.Point(104, 79);
            this.mainDecision_button.Name = "mainDecision_button";
            this.mainDecision_button.Size = new System.Drawing.Size(243, 45);
            this.mainDecision_button.TabIndex = 1;
            this.mainDecision_button.Text = "決定";
            this.mainDecision_button.UseVisualStyleBackColor = true;
            this.mainDecision_button.Click += new System.EventHandler(this.mainDecision_button_Click);
            // 
            // mainInputPassword_textBox
            // 
            this.mainInputPassword_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainInputPassword_textBox.Location = new System.Drawing.Point(25, 23);
            this.mainInputPassword_textBox.Name = "mainInputPassword_textBox";
            this.mainInputPassword_textBox.PasswordChar = '●';
            this.mainInputPassword_textBox.Size = new System.Drawing.Size(234, 27);
            this.mainInputPassword_textBox.TabIndex = 0;
            this.mainInputPassword_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainInputPassword_textBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DireCrypt.Properties.Resources.encryption_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mainCancel_button
            // 
            this.mainCancel_button.Location = new System.Drawing.Point(12, 79);
            this.mainCancel_button.Name = "mainCancel_button";
            this.mainCancel_button.Size = new System.Drawing.Size(88, 45);
            this.mainCancel_button.TabIndex = 5;
            this.mainCancel_button.Text = "キャンセル";
            this.mainCancel_button.UseVisualStyleBackColor = true;
            this.mainCancel_button.Click += new System.EventHandler(this.mainCancel_button_Click);
            // 
            // InputPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 137);
            this.Controls.Add(this.mainCancel_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainDecision_button);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputPasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "パスワードの入力";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputPasswordForm_FormClosing);
            this.Load += new System.EventHandler(this.InputPasswordForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mainDecision_button;
        private System.Windows.Forms.TextBox mainInputPassword_textBox;
        private System.Windows.Forms.CheckBox mainShowPassword_checkBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mainCancel_button;
    }
}