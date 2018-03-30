namespace DireCrypt
{
    partial class SetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPasswordForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainReInput_textBox = new System.Windows.Forms.TextBox();
            this.mainInput_textBox = new System.Windows.Forms.TextBox();
            this.mainStart_button = new System.Windows.Forms.Button();
            this.mainCancel_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mainReInput_textBox);
            this.groupBox1.Controls.Add(this.mainInput_textBox);
            this.groupBox1.Location = new System.Drawing.Point(79, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "パスワードの入力";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "再入力:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "入力:";
            // 
            // mainReInput_textBox
            // 
            this.mainReInput_textBox.Location = new System.Drawing.Point(58, 51);
            this.mainReInput_textBox.Name = "mainReInput_textBox";
            this.mainReInput_textBox.PasswordChar = '●';
            this.mainReInput_textBox.Size = new System.Drawing.Size(171, 23);
            this.mainReInput_textBox.TabIndex = 1;
            this.mainReInput_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainReInput_textBox_KeyPress);
            // 
            // mainInput_textBox
            // 
            this.mainInput_textBox.Location = new System.Drawing.Point(58, 22);
            this.mainInput_textBox.Name = "mainInput_textBox";
            this.mainInput_textBox.PasswordChar = '●';
            this.mainInput_textBox.Size = new System.Drawing.Size(171, 23);
            this.mainInput_textBox.TabIndex = 0;
            this.mainInput_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainInput_textBox_KeyPress);
            // 
            // mainStart_button
            // 
            this.mainStart_button.Location = new System.Drawing.Point(137, 105);
            this.mainStart_button.Name = "mainStart_button";
            this.mainStart_button.Size = new System.Drawing.Size(186, 49);
            this.mainStart_button.TabIndex = 1;
            this.mainStart_button.Text = "実行";
            this.mainStart_button.UseVisualStyleBackColor = true;
            this.mainStart_button.Click += new System.EventHandler(this.mainStart_button_Click);
            // 
            // mainCancel_button
            // 
            this.mainCancel_button.Location = new System.Drawing.Point(12, 105);
            this.mainCancel_button.Name = "mainCancel_button";
            this.mainCancel_button.Size = new System.Drawing.Size(119, 49);
            this.mainCancel_button.TabIndex = 2;
            this.mainCancel_button.Text = "キャンセル";
            this.mainCancel_button.UseVisualStyleBackColor = true;
            this.mainCancel_button.Click += new System.EventHandler(this.mainCancel_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DireCrypt.Properties.Resources.encryption_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 168);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainCancel_button);
            this.Controls.Add(this.mainStart_button);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetPasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "パスワードを設定";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetPasswordForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mainStart_button;
        private System.Windows.Forms.Button mainCancel_button;
        private System.Windows.Forms.TextBox mainReInput_textBox;
        private System.Windows.Forms.TextBox mainInput_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}