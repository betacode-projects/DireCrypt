namespace DireCrypt
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainFilePath_comboBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainDecrypt_Panel = new System.Windows.Forms.Panel();
            this.mainEncrypt_Panel = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainShowPath_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainDeletePath_button = new System.Windows.Forms.Button();
            this.mainDirectoryShow_button = new System.Windows.Forms.Button();
            this.mainFileShow_button = new System.Windows.Forms.Button();
            this.helpShow_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cryptHelpShow_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.mainDecrypt_Panel.SuspendLayout();
            this.mainEncrypt_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.mainFilePath_comboBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 46);
            this.panel1.TabIndex = 5;
            // 
            // mainFilePath_comboBox
            // 
            this.mainFilePath_comboBox.BackColor = System.Drawing.SystemColors.Control;
            this.mainFilePath_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainFilePath_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mainFilePath_comboBox.FormattingEnabled = true;
            this.mainFilePath_comboBox.Location = new System.Drawing.Point(12, 10);
            this.mainFilePath_comboBox.Name = "mainFilePath_comboBox";
            this.mainFilePath_comboBox.Size = new System.Drawing.Size(303, 23);
            this.mainFilePath_comboBox.TabIndex = 2;
            this.mainFilePath_comboBox.SelectedIndexChanged += new System.EventHandler(this.mainFilePath_comboBox_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mainDeletePath_button);
            this.panel4.Controls.Add(this.mainDirectoryShow_button);
            this.panel4.Controls.Add(this.mainFileShow_button);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(321, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 46);
            this.panel4.TabIndex = 1;
            // 
            // mainDecrypt_Panel
            // 
            this.mainDecrypt_Panel.AllowDrop = true;
            this.mainDecrypt_Panel.BackColor = System.Drawing.Color.LightCoral;
            this.mainDecrypt_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDecrypt_Panel.Controls.Add(this.pictureBox2);
            this.mainDecrypt_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainDecrypt_Panel.Location = new System.Drawing.Point(230, 46);
            this.mainDecrypt_Panel.Name = "mainDecrypt_Panel";
            this.mainDecrypt_Panel.Size = new System.Drawing.Size(230, 162);
            this.mainDecrypt_Panel.TabIndex = 7;
            this.mainDecrypt_Panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainDecrypt_Panel_DragDrop);
            this.mainDecrypt_Panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainDecrypt_Panel_DragEnter);
            this.mainDecrypt_Panel.DragLeave += new System.EventHandler(this.mainDecrypt_Panel_DragLeave);
            this.mainDecrypt_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainDecrypt_Panel_MouseDown);
            this.mainDecrypt_Panel.MouseEnter += new System.EventHandler(this.mainDecrypt_panel_MouseEnter);
            this.mainDecrypt_Panel.MouseLeave += new System.EventHandler(this.mainDecrypt_panel_MouseLeave);
            this.mainDecrypt_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainDecrypt_Panel_MouseUp);
            // 
            // mainEncrypt_Panel
            // 
            this.mainEncrypt_Panel.AllowDrop = true;
            this.mainEncrypt_Panel.BackColor = System.Drawing.Color.PaleGreen;
            this.mainEncrypt_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainEncrypt_Panel.Controls.Add(this.pictureBox1);
            this.mainEncrypt_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainEncrypt_Panel.Location = new System.Drawing.Point(0, 46);
            this.mainEncrypt_Panel.Name = "mainEncrypt_Panel";
            this.mainEncrypt_Panel.Size = new System.Drawing.Size(230, 162);
            this.mainEncrypt_Panel.TabIndex = 6;
            this.mainEncrypt_Panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainEncrypt_Panel_DragDrop);
            this.mainEncrypt_Panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainEncrypt_Panel_DragEnter);
            this.mainEncrypt_Panel.DragLeave += new System.EventHandler(this.mainEncrypt_Panel_DragLeave);
            this.mainEncrypt_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainEncrypt_Panel_MouseDown);
            this.mainEncrypt_Panel.MouseEnter += new System.EventHandler(this.mainEncrypt_Panel_MouseEnter);
            this.mainEncrypt_Panel.MouseLeave += new System.EventHandler(this.mainEncrypt_Panel_MouseLeave);
            this.mainEncrypt_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainEncrypt_Panel_MouseUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "すべてのファイル|*.*|画像ファイル|*.gif;*.png;*.jpg;*.jpeg|バイナリファイル|.exe;*.com;*.dll|音楽ファイル|*.m" +
    "p3;*.wav|動画ファイル|*.mp4;.mpeg:*.avi|圧縮ファイル|*.rar;*.zip;*.lhz;*.7zip";
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "ファイルの選択";
            // 
            // mainShowPath_toolTip
            // 
            this.mainShowPath_toolTip.AutoPopDelay = 10000;
            this.mainShowPath_toolTip.InitialDelay = 500;
            this.mainShowPath_toolTip.ReshowDelay = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::DireCrypt.Properties.Resources.unlock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.cryptHelpShow_toolTip.SetToolTip(this.pictureBox2, "選択されたファイル・フォルダを復号化します。");
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainDecrypt_Panel_DragDrop);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainDecrypt_Panel_DragEnter);
            this.pictureBox2.DragLeave += new System.EventHandler(this.mainDecrypt_Panel_DragLeave);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainDecrypt_Panel_MouseDown);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.mainDecrypt_panel_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.mainDecrypt_panel_MouseLeave);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainDecrypt_Panel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DireCrypt.Properties.Resources.lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.cryptHelpShow_toolTip.SetToolTip(this.pictureBox1, "選択されたファイル・フォルダを暗号化します。");
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainEncrypt_Panel_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainEncrypt_Panel_DragEnter);
            this.pictureBox1.DragLeave += new System.EventHandler(this.mainEncrypt_Panel_DragLeave);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainEncrypt_Panel_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.mainEncrypt_Panel_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.mainEncrypt_Panel_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainEncrypt_Panel_MouseUp);
            // 
            // mainDeletePath_button
            // 
            this.mainDeletePath_button.Image = global::DireCrypt.Properties.Resources.delete_icon;
            this.mainDeletePath_button.Location = new System.Drawing.Point(89, 9);
            this.mainDeletePath_button.Name = "mainDeletePath_button";
            this.mainDeletePath_button.Size = new System.Drawing.Size(37, 24);
            this.mainDeletePath_button.TabIndex = 2;
            this.helpShow_toolTip.SetToolTip(this.mainDeletePath_button, "選択されている項目のファイルパスを削除します。");
            this.mainDeletePath_button.UseVisualStyleBackColor = true;
            this.mainDeletePath_button.Click += new System.EventHandler(this.mainDeletePath_button_Click);
            // 
            // mainDirectoryShow_button
            // 
            this.mainDirectoryShow_button.Image = global::DireCrypt.Properties.Resources.folder_icon;
            this.mainDirectoryShow_button.Location = new System.Drawing.Point(46, 9);
            this.mainDirectoryShow_button.Name = "mainDirectoryShow_button";
            this.mainDirectoryShow_button.Size = new System.Drawing.Size(37, 24);
            this.mainDirectoryShow_button.TabIndex = 1;
            this.helpShow_toolTip.SetToolTip(this.mainDirectoryShow_button, "暗号化・復号化するフォルダを選択します。");
            this.mainDirectoryShow_button.UseVisualStyleBackColor = true;
            this.mainDirectoryShow_button.Click += new System.EventHandler(this.mainDirectoryShow_button_Click);
            // 
            // mainFileShow_button
            // 
            this.mainFileShow_button.Image = global::DireCrypt.Properties.Resources.file_icon;
            this.mainFileShow_button.Location = new System.Drawing.Point(3, 9);
            this.mainFileShow_button.Name = "mainFileShow_button";
            this.mainFileShow_button.Size = new System.Drawing.Size(37, 24);
            this.mainFileShow_button.TabIndex = 0;
            this.helpShow_toolTip.SetToolTip(this.mainFileShow_button, "暗号化・復号化するファイルを選択します。");
            this.mainFileShow_button.UseVisualStyleBackColor = true;
            this.mainFileShow_button.Click += new System.EventHandler(this.mainFileShow_button_Click);
            // 
            // helpShow_toolTip
            // 
            this.helpShow_toolTip.AutoPopDelay = 10000;
            this.helpShow_toolTip.InitialDelay = 500;
            this.helpShow_toolTip.ReshowDelay = 100;
            // 
            // cryptHelpShow_toolTip
            // 
            this.cryptHelpShow_toolTip.AutoPopDelay = 10000;
            this.cryptHelpShow_toolTip.InitialDelay = 500;
            this.cryptHelpShow_toolTip.IsBalloon = true;
            this.cryptHelpShow_toolTip.ReshowDelay = 100;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 208);
            this.Controls.Add(this.mainDecrypt_Panel);
            this.Controls.Add(this.mainEncrypt_Panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DireCrypt v1.20";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.mainDecrypt_Panel.ResumeLayout(false);
            this.mainEncrypt_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button mainFileShow_button;
        private System.Windows.Forms.Button mainDirectoryShow_button;
        private System.Windows.Forms.Panel mainDecrypt_Panel;
        private System.Windows.Forms.Panel mainEncrypt_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox mainFilePath_comboBox;
        private System.Windows.Forms.ToolTip mainShowPath_toolTip;
        private System.Windows.Forms.Button mainDeletePath_button;
        private System.Windows.Forms.ToolTip helpShow_toolTip;
        private System.Windows.Forms.ToolTip cryptHelpShow_toolTip;
    }
}

