namespace DireCrypt
{
    partial class ProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainStatus_textBox = new System.Windows.Forms.TextBox();
            this.mainClose_Button = new System.Windows.Forms.Button();
            this.mainStatus_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainShow_button = new System.Windows.Forms.Button();
            this.main_ProgressBar = new PercentProgressBar();
            this.groupBox1.SuspendLayout();
            this.mainStatus_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mainStatus_textBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(550, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "進行状況";
            // 
            // mainStatus_textBox
            // 
            this.mainStatus_textBox.BackColor = System.Drawing.Color.White;
            this.mainStatus_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainStatus_textBox.Location = new System.Drawing.Point(3, 20);
            this.mainStatus_textBox.Multiline = true;
            this.mainStatus_textBox.Name = "mainStatus_textBox";
            this.mainStatus_textBox.ReadOnly = true;
            this.mainStatus_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainStatus_textBox.Size = new System.Drawing.Size(544, 264);
            this.mainStatus_textBox.TabIndex = 0;
            this.mainStatus_textBox.WordWrap = false;
            // 
            // mainClose_Button
            // 
            this.mainClose_Button.Enabled = false;
            this.mainClose_Button.Location = new System.Drawing.Point(74, 3);
            this.mainClose_Button.Name = "mainClose_Button";
            this.mainClose_Button.Size = new System.Drawing.Size(64, 29);
            this.mainClose_Button.TabIndex = 2;
            this.mainClose_Button.Text = "閉じる";
            this.mainClose_Button.UseVisualStyleBackColor = true;
            this.mainClose_Button.Click += new System.EventHandler(this.mainClose_Button_Click);
            // 
            // mainStatus_panel
            // 
            this.mainStatus_panel.Controls.Add(this.groupBox1);
            this.mainStatus_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainStatus_panel.Location = new System.Drawing.Point(0, 0);
            this.mainStatus_panel.Name = "mainStatus_panel";
            this.mainStatus_panel.Size = new System.Drawing.Size(574, 351);
            this.mainStatus_panel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.main_ProgressBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 43);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mainShow_button);
            this.panel3.Controls.Add(this.mainClose_Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(424, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 43);
            this.panel3.TabIndex = 5;
            // 
            // mainShow_button
            // 
            this.mainShow_button.Location = new System.Drawing.Point(4, 3);
            this.mainShow_button.Name = "mainShow_button";
            this.mainShow_button.Size = new System.Drawing.Size(64, 29);
            this.mainShow_button.TabIndex = 3;
            this.mainShow_button.Text = "非更新";
            this.mainShow_button.UseVisualStyleBackColor = true;
            this.mainShow_button.Click += new System.EventHandler(this.mainShow_button_Click);
            // 
            // main_ProgressBar
            // 
            this.main_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_ProgressBar.Location = new System.Drawing.Point(12, 3);
            this.main_ProgressBar.Name = "main_ProgressBar";
            this.main_ProgressBar.Size = new System.Drawing.Size(410, 28);
            this.main_ProgressBar.TabIndex = 1;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainStatus_panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(590, 390);
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "進行中...";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.Shown += new System.EventHandler(this.ProgressForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainStatus_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mainStatus_textBox;
        private PercentProgressBar main_ProgressBar;
        private System.Windows.Forms.Button mainClose_Button;
        private System.Windows.Forms.Panel mainStatus_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button mainShow_button;
    }
}