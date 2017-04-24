namespace aws_uploader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbx_directory = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.dgv_fileList = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_buckets = new System.Windows.Forms.GroupBox();
            this.tvw_buckets = new System.Windows.Forms.TreeView();
            this.btn_refreshBucket = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_removeBucket = new System.Windows.Forms.Button();
            this.btn_addBucket = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabctrl = new System.Windows.Forms.TabControl();
            this.tab_upload = new System.Windows.Forms.TabPage();
            this.tab_fileManager = new System.Windows.Forms.TabPage();
            this.ofd_getFolders = new System.Windows.Forms.OpenFileDialog();
            this.ofd_getFiles = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fileList)).BeginInit();
            this.gbx_buckets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabctrl.SuspendLayout();
            this.tab_upload.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_directory
            // 
            this.tbx_directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_directory.Location = new System.Drawing.Point(6, 6);
            this.tbx_directory.Name = "tbx_directory";
            this.tbx_directory.Size = new System.Drawing.Size(652, 22);
            this.tbx_directory.TabIndex = 5;
            this.tbx_directory.Text = "Choose Directory...";
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_upload.Location = new System.Drawing.Point(665, 484);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(87, 107);
            this.btn_upload.TabIndex = 4;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteItem.Location = new System.Drawing.Point(662, 97);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(87, 54);
            this.btn_deleteItem.TabIndex = 3;
            this.btn_deleteItem.Text = "Delete Item";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addItem.Location = new System.Drawing.Point(662, 37);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(87, 54);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add File(s)";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.Location = new System.Drawing.Point(662, 6);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(87, 25);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // dgv_fileList
            // 
            this.dgv_fileList.AllowUserToAddRows = false;
            this.dgv_fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvType});
            this.dgv_fileList.Location = new System.Drawing.Point(6, 37);
            this.dgv_fileList.Name = "dgv_fileList";
            this.dgv_fileList.RowHeadersVisible = false;
            this.dgv_fileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fileList.Size = new System.Drawing.Size(653, 554);
            this.dgv_fileList.TabIndex = 0;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            // 
            // dgvType
            // 
            this.dgvType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvType.HeaderText = "Type";
            this.dgvType.Name = "dgvType";
            // 
            // gbx_buckets
            // 
            this.gbx_buckets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_buckets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbx_buckets.Controls.Add(this.tvw_buckets);
            this.gbx_buckets.Controls.Add(this.btn_refreshBucket);
            this.gbx_buckets.Controls.Add(this.btn_settings);
            this.gbx_buckets.Controls.Add(this.btn_removeBucket);
            this.gbx_buckets.Controls.Add(this.btn_addBucket);
            this.gbx_buckets.Location = new System.Drawing.Point(3, 3);
            this.gbx_buckets.Name = "gbx_buckets";
            this.gbx_buckets.Size = new System.Drawing.Size(380, 632);
            this.gbx_buckets.TabIndex = 0;
            this.gbx_buckets.TabStop = false;
            this.gbx_buckets.Text = "Buckets";
            // 
            // tvw_buckets
            // 
            this.tvw_buckets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvw_buckets.Location = new System.Drawing.Point(8, 55);
            this.tvw_buckets.Name = "tvw_buckets";
            this.tvw_buckets.Size = new System.Drawing.Size(365, 559);
            this.tvw_buckets.TabIndex = 5;
            // 
            // btn_refreshBucket
            // 
            this.btn_refreshBucket.Image = ((System.Drawing.Image)(resources.GetObject("btn_refreshBucket.Image")));
            this.btn_refreshBucket.Location = new System.Drawing.Point(79, 21);
            this.btn_refreshBucket.Name = "btn_refreshBucket";
            this.btn_refreshBucket.Size = new System.Drawing.Size(29, 27);
            this.btn_refreshBucket.TabIndex = 4;
            this.btn_refreshBucket.UseVisualStyleBackColor = true;
            this.btn_refreshBucket.Click += new System.EventHandler(this.btn_refreshBucket_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.Location = new System.Drawing.Point(344, 21);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(29, 27);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_removeBucket
            // 
            this.btn_removeBucket.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeBucket.Image")));
            this.btn_removeBucket.Location = new System.Drawing.Point(44, 21);
            this.btn_removeBucket.Name = "btn_removeBucket";
            this.btn_removeBucket.Size = new System.Drawing.Size(29, 27);
            this.btn_removeBucket.TabIndex = 1;
            this.btn_removeBucket.UseVisualStyleBackColor = true;
            // 
            // btn_addBucket
            // 
            this.btn_addBucket.Image = ((System.Drawing.Image)(resources.GetObject("btn_addBucket.Image")));
            this.btn_addBucket.Location = new System.Drawing.Point(8, 21);
            this.btn_addBucket.Name = "btn_addBucket";
            this.btn_addBucket.Size = new System.Drawing.Size(29, 27);
            this.btn_addBucket.TabIndex = 0;
            this.btn_addBucket.UseVisualStyleBackColor = true;
            this.btn_addBucket.Click += new System.EventHandler(this.btn_addBucket_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbx_buckets);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabctrl);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 638);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabctrl
            // 
            this.tabctrl.Controls.Add(this.tab_upload);
            this.tabctrl.Controls.Add(this.tab_fileManager);
            this.tabctrl.Location = new System.Drawing.Point(4, 4);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.Size = new System.Drawing.Size(763, 631);
            this.tabctrl.TabIndex = 2;
            // 
            // tab_upload
            // 
            this.tab_upload.Controls.Add(this.btn_upload);
            this.tab_upload.Controls.Add(this.tbx_directory);
            this.tab_upload.Controls.Add(this.btn_deleteItem);
            this.tab_upload.Controls.Add(this.btn_addItem);
            this.tab_upload.Controls.Add(this.dgv_fileList);
            this.tab_upload.Controls.Add(this.btn_browse);
            this.tab_upload.Location = new System.Drawing.Point(4, 22);
            this.tab_upload.Name = "tab_upload";
            this.tab_upload.Padding = new System.Windows.Forms.Padding(3);
            this.tab_upload.Size = new System.Drawing.Size(755, 605);
            this.tab_upload.TabIndex = 0;
            this.tab_upload.Text = "Upload";
            this.tab_upload.UseVisualStyleBackColor = true;
            // 
            // tab_fileManager
            // 
            this.tab_fileManager.Location = new System.Drawing.Point(4, 22);
            this.tab_fileManager.Name = "tab_fileManager";
            this.tab_fileManager.Padding = new System.Windows.Forms.Padding(3);
            this.tab_fileManager.Size = new System.Drawing.Size(755, 605);
            this.tab_fileManager.TabIndex = 1;
            this.tab_fileManager.Text = "Files";
            this.tab_fileManager.UseVisualStyleBackColor = true;
            // 
            // ofd_getFolders
            // 
            this.ofd_getFolders.CheckFileExists = false;
            this.ofd_getFolders.FileName = "Choose Folder";
            this.ofd_getFolders.Filter = "folders|*.";
            this.ofd_getFolders.ValidateNames = false;
            // 
            // ofd_getFiles
            // 
            this.ofd_getFiles.FileName = "Choose File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Droid Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmMain";
            this.Text = "AWS S3 Browser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fileList)).EndInit();
            this.gbx_buckets.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabctrl.ResumeLayout(false);
            this.tab_upload.ResumeLayout(false);
            this.tab_upload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_directory;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.DataGridView dgv_fileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_type;
        private System.Windows.Forms.GroupBox gbx_buckets;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_removeBucket;
        private System.Windows.Forms.Button btn_addBucket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvType;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog ofd_getFolders;
        private System.Windows.Forms.OpenFileDialog ofd_getFiles;
        private System.Windows.Forms.Button btn_refreshBucket;
        private System.Windows.Forms.TreeView tvw_buckets;
        private System.Windows.Forms.TabControl tabctrl;
        private System.Windows.Forms.TabPage tab_upload;
        private System.Windows.Forms.TabPage tab_fileManager;
    }
}

