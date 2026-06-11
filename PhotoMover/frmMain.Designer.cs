namespace PhotoMover
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
            this.fbSourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fbDestinationBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_DontMove = new System.Windows.Forms.CheckBox();
            this.chkTouch = new System.Windows.Forms.CheckBox();
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerMove = new System.ComponentModel.BackgroundWorker();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.tabErrors = new System.Windows.Forms.TabPage();
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.tabErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(15, 11);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(97, 17);
            this.lblSourceFolder.TabIndex = 0;
            this.lblSourceFolder.Text = "Source Folder";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(15, 30);
            this.txtSourceFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(364, 22);
            this.txtSourceFolder.TabIndex = 1;
            this.txtSourceFolder.TextChanged += new System.EventHandler(this.TxtSourceFolder_TextChanged);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(385, 30);
            this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(68, 25);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Select";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(385, 96);
            this.btnBrowseDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(68, 25);
            this.btnBrowseDestination.TabIndex = 5;
            this.btnBrowseDestination.Text = "Select";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(15, 96);
            this.txtDestinationFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(364, 22);
            this.txtDestinationFolder.TabIndex = 4;
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Location = new System.Drawing.Point(15, 78);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(123, 17);
            this.lblDestinationFolder.TabIndex = 3;
            this.lblDestinationFolder.Text = "Destination Folder";
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(15, 133);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 28);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Enabled = false;
            this.btnMoveFiles.Location = new System.Drawing.Point(123, 133);
            this.btnMoveFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(100, 28);
            this.btnMoveFiles.TabIndex = 8;
            this.btnMoveFiles.Text = "Move";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_DontMove);
            this.groupBox1.Controls.Add(this.chkTouch);
            this.groupBox1.Controls.Add(this.txtDateFormat);
            this.groupBox1.Controls.Add(this.lblDateFormat);
            this.groupBox1.Controls.Add(this.rbCopy);
            this.groupBox1.Controls.Add(this.rbMove);
            this.groupBox1.Location = new System.Drawing.Point(655, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(405, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chk_DontMove
            // 
            this.chk_DontMove.AutoSize = true;
            this.chk_DontMove.Location = new System.Drawing.Point(200, 54);
            this.chk_DontMove.Margin = new System.Windows.Forms.Padding(4);
            this.chk_DontMove.Name = "chk_DontMove";
            this.chk_DontMove.Size = new System.Drawing.Size(188, 21);
            this.chk_DontMove.TabIndex = 5;
            this.chk_DontMove.Text = "Touch Only (Don\'t Move)";
            this.chk_DontMove.UseVisualStyleBackColor = true;
            // 
            // chkTouch
            // 
            this.chkTouch.AutoSize = true;
            this.chkTouch.Location = new System.Drawing.Point(200, 26);
            this.chkTouch.Margin = new System.Windows.Forms.Padding(4);
            this.chkTouch.Name = "chkTouch";
            this.chkTouch.Size = new System.Drawing.Size(176, 21);
            this.chkTouch.TabIndex = 4;
            this.chkTouch.Text = "Touch with Date Taken";
            this.chkTouch.UseVisualStyleBackColor = true;
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.Location = new System.Drawing.Point(9, 118);
            this.txtDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(132, 22);
            this.txtDateFormat.TabIndex = 3;
            this.txtDateFormat.Text = "yyyy-MM-dd";
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(9, 97);
            this.lblDateFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(86, 17);
            this.lblDateFormat.TabIndex = 2;
            this.lblDateFormat.Text = "Date Format";
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(9, 54);
            this.rbCopy.Margin = new System.Windows.Forms.Padding(4);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(94, 21);
            this.rbCopy.TabIndex = 1;
            this.rbCopy.Text = "Copy Files";
            this.rbCopy.UseVisualStyleBackColor = true;
            this.rbCopy.CheckedChanged += new System.EventHandler(this.rbCopy_CheckedChanged);
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Checked = true;
            this.rbMove.Location = new System.Drawing.Point(9, 25);
            this.rbMove.Margin = new System.Windows.Forms.Padding(4);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(96, 21);
            this.rbMove.TabIndex = 0;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move Files";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(15, 178);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(64, 17);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "progress";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Controls.Add(this.tabErrors);
            this.tabControl1.Location = new System.Drawing.Point(18, 216);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 344);
            this.tabControl1.TabIndex = 11;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.gvResults);
            this.tabResults.Location = new System.Drawing.Point(4, 25);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(1034, 315);
            this.tabResults.TabIndex = 0;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResults.Location = new System.Drawing.Point(3, 3);
            this.gvResults.Margin = new System.Windows.Forms.Padding(4);
            this.gvResults.Name = "gvResults";
            this.gvResults.ReadOnly = true;
            this.gvResults.RowHeadersWidth = 51;
            this.gvResults.ShowCellToolTips = false;
            this.gvResults.ShowEditingIcon = false;
            this.gvResults.Size = new System.Drawing.Size(1028, 309);
            this.gvResults.TabIndex = 8;
            // 
            // tabErrors
            // 
            this.tabErrors.Controls.Add(this.lstErrors);
            this.tabErrors.Location = new System.Drawing.Point(4, 25);
            this.tabErrors.Name = "tabErrors";
            this.tabErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrors.Size = new System.Drawing.Size(1034, 137);
            this.tabErrors.TabIndex = 1;
            this.tabErrors.Text = "Errors (0)";
            this.tabErrors.UseVisualStyleBackColor = true;
            // 
            // lstErrors
            // 
            this.lstErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstErrors.FormattingEnabled = true;
            this.lstErrors.ItemHeight = 16;
            this.lstErrors.Location = new System.Drawing.Point(3, 3);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(1028, 131);
            this.lstErrors.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.lblSourceFolder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "PhotoMover - Move Photos Into Date Folders from DateTaken";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.tabErrors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog fbDestinationBrowser;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbMove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMove;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.CheckBox chkTouch;
        private System.Windows.Forms.CheckBox chk_DontMove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.TabPage tabErrors;
        private System.Windows.Forms.ListBox lstErrors;
    }
}

