namespace aws_uploader
{
    partial class aws_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aws_settings));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.pnl_settingsButtons = new System.Windows.Forms.Panel();
            this.pnl_settingsInfo = new System.Windows.Forms.Panel();
            this.lbl_accountName = new System.Windows.Forms.Label();
            this.tbx_accountName = new System.Windows.Forms.TextBox();
            this.lbl_accessKey = new System.Windows.Forms.Label();
            this.tbx_accessKey = new System.Windows.Forms.TextBox();
            this.tbx_secretKey = new System.Windows.Forms.TextBox();
            this.lbl_secretKey = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_settingsButtons.SuspendLayout();
            this.pnl_settingsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(144, 3);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(225, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.Location = new System.Drawing.Point(306, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // pnl_settingsButtons
            // 
            this.pnl_settingsButtons.Controls.Add(this.btn_ok);
            this.pnl_settingsButtons.Controls.Add(this.btn_cancel);
            this.pnl_settingsButtons.Controls.Add(this.btn_apply);
            this.pnl_settingsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_settingsButtons.Location = new System.Drawing.Point(0, 233);
            this.pnl_settingsButtons.Name = "pnl_settingsButtons";
            this.pnl_settingsButtons.Size = new System.Drawing.Size(384, 29);
            this.pnl_settingsButtons.TabIndex = 3;
            // 
            // pnl_settingsInfo
            // 
            this.pnl_settingsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_settingsInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_settingsInfo.Controls.Add(this.lbl_secretKey);
            this.pnl_settingsInfo.Controls.Add(this.tbx_secretKey);
            this.pnl_settingsInfo.Controls.Add(this.tbx_accessKey);
            this.pnl_settingsInfo.Controls.Add(this.lbl_accessKey);
            this.pnl_settingsInfo.Controls.Add(this.tbx_accountName);
            this.pnl_settingsInfo.Controls.Add(this.lbl_accountName);
            this.pnl_settingsInfo.Location = new System.Drawing.Point(0, 78);
            this.pnl_settingsInfo.Name = "pnl_settingsInfo";
            this.pnl_settingsInfo.Size = new System.Drawing.Size(381, 149);
            this.pnl_settingsInfo.TabIndex = 4;
            // 
            // lbl_accountName
            // 
            this.lbl_accountName.AutoSize = true;
            this.lbl_accountName.Location = new System.Drawing.Point(4, 4);
            this.lbl_accountName.Name = "lbl_accountName";
            this.lbl_accountName.Size = new System.Drawing.Size(81, 13);
            this.lbl_accountName.TabIndex = 0;
            this.lbl_accountName.Text = "Account Name:";
            // 
            // tbx_accountName
            // 
            this.tbx_accountName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_accountName.Location = new System.Drawing.Point(7, 19);
            this.tbx_accountName.Name = "tbx_accountName";
            this.tbx_accountName.Size = new System.Drawing.Size(365, 20);
            this.tbx_accountName.TabIndex = 1;
            // 
            // lbl_accessKey
            // 
            this.lbl_accessKey.AutoSize = true;
            this.lbl_accessKey.Location = new System.Drawing.Point(4, 44);
            this.lbl_accessKey.Name = "lbl_accessKey";
            this.lbl_accessKey.Size = new System.Drawing.Size(80, 13);
            this.lbl_accessKey.TabIndex = 2;
            this.lbl_accessKey.Text = "Access Key ID:";
            // 
            // tbx_accessKey
            // 
            this.tbx_accessKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_accessKey.Location = new System.Drawing.Point(7, 60);
            this.tbx_accessKey.Name = "tbx_accessKey";
            this.tbx_accessKey.Size = new System.Drawing.Size(365, 20);
            this.tbx_accessKey.TabIndex = 3;
            // 
            // tbx_secretKey
            // 
            this.tbx_secretKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_secretKey.Location = new System.Drawing.Point(7, 104);
            this.tbx_secretKey.Name = "tbx_secretKey";
            this.tbx_secretKey.Size = new System.Drawing.Size(365, 20);
            this.tbx_secretKey.TabIndex = 4;
            // 
            // lbl_secretKey
            // 
            this.lbl_secretKey.AutoSize = true;
            this.lbl_secretKey.Location = new System.Drawing.Point(7, 88);
            this.lbl_secretKey.Name = "lbl_secretKey";
            this.lbl_secretKey.Size = new System.Drawing.Size(100, 13);
            this.lbl_secretKey.TabIndex = 5;
            this.lbl_secretKey.Text = "Secret Access Key:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // aws_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_settingsInfo);
            this.Controls.Add(this.pnl_settingsButtons);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "aws_settings";
            this.Text = "Settings";
            this.pnl_settingsButtons.ResumeLayout(false);
            this.pnl_settingsInfo.ResumeLayout(false);
            this.pnl_settingsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Panel pnl_settingsButtons;
        private System.Windows.Forms.Panel pnl_settingsInfo;
        private System.Windows.Forms.Label lbl_secretKey;
        private System.Windows.Forms.TextBox tbx_secretKey;
        private System.Windows.Forms.TextBox tbx_accessKey;
        private System.Windows.Forms.Label lbl_accessKey;
        private System.Windows.Forms.TextBox tbx_accountName;
        private System.Windows.Forms.Label lbl_accountName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}