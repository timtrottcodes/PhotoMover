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
            this.components = new System.ComponentModel.Container();
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
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblDateFormatHelp = new System.Windows.Forms.Label();
            this.chk_DontMove = new System.Windows.Forms.CheckBox();
            this.chkTouch = new System.Windows.Forms.CheckBox();
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerMove = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.tabErrors = new System.Windows.Forms.TabPage();
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpFolders = new System.Windows.Forms.GroupBox();
            this.lblSourceHelp = new System.Windows.Forms.Label();
            this.lblDestHelp = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAppDescription = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.tabErrors.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpFolders.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.Controls.Add(this.lblAppDescription);
            this.panelHeader.Controls.Add(this.lblAppTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(1100, 85);
            this.panelHeader.TabIndex = 0;
            //
            // lblAppTitle
            //
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.Location = new System.Drawing.Point(20, 15);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(147, 30);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "PhotoMover";
            //
            // lblAppDescription
            //
            this.lblAppDescription.AutoSize = true;
            this.lblAppDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppDescription.Location = new System.Drawing.Point(22, 48);
            this.lblAppDescription.Name = "lblAppDescription";
            this.lblAppDescription.Size = new System.Drawing.Size(480, 15);
            this.lblAppDescription.TabIndex = 1;
            this.lblAppDescription.Text = "Organize photos into date-based folders using EXIF metadata from JPEG and RAW files";
            //
            // grpFolders
            //
            this.grpFolders.Controls.Add(this.lblDestHelp);
            this.grpFolders.Controls.Add(this.lblSourceHelp);
            this.grpFolders.Controls.Add(this.lblSourceFolder);
            this.grpFolders.Controls.Add(this.txtSourceFolder);
            this.grpFolders.Controls.Add(this.btnBrowseSource);
            this.grpFolders.Controls.Add(this.lblDestinationFolder);
            this.grpFolders.Controls.Add(this.txtDestinationFolder);
            this.grpFolders.Controls.Add(this.btnBrowseDestination);
            this.grpFolders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpFolders.Location = new System.Drawing.Point(20, 100);
            this.grpFolders.Name = "grpFolders";
            this.grpFolders.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpFolders.Size = new System.Drawing.Size(540, 185);
            this.grpFolders.TabIndex = 1;
            this.grpFolders.TabStop = false;
            this.grpFolders.Text = "📁 Folder Selection";
            //
            // lblSourceFolder
            //
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSourceFolder.Location = new System.Drawing.Point(15, 28);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(89, 15);
            this.lblSourceFolder.TabIndex = 0;
            this.lblSourceFolder.Text = "Source Folder:";
            //
            // lblSourceHelp
            //
            this.lblSourceHelp.AutoSize = true;
            this.lblSourceHelp.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSourceHelp.Location = new System.Drawing.Point(15, 73);
            this.lblSourceHelp.Name = "lblSourceHelp";
            this.lblSourceHelp.Size = new System.Drawing.Size(250, 13);
            this.lblSourceHelp.TabIndex = 3;
            this.lblSourceHelp.Text = "The folder containing photos you want to organize";
            //
            // txtSourceFolder
            //
            this.txtSourceFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSourceFolder.Location = new System.Drawing.Point(15, 48);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(415, 23);
            this.txtSourceFolder.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSourceFolder, "Select the folder containing your photos");
            this.txtSourceFolder.TextChanged += new System.EventHandler(this.TxtSourceFolder_TextChanged);
            //
            // btnBrowseSource
            //
            this.btnBrowseSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseSource.Location = new System.Drawing.Point(436, 47);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(85, 25);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Browse...";
            this.toolTip1.SetToolTip(this.btnBrowseSource, "Click to select source folder");
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            //
            // lblDestinationFolder
            //
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDestinationFolder.Location = new System.Drawing.Point(15, 98);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(116, 15);
            this.lblDestinationFolder.TabIndex = 4;
            this.lblDestinationFolder.Text = "Destination Folder:";
            //
            // lblDestHelp
            //
            this.lblDestHelp.AutoSize = true;
            this.lblDestHelp.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDestHelp.Location = new System.Drawing.Point(15, 143);
            this.lblDestHelp.Name = "lblDestHelp";
            this.lblDestHelp.Size = new System.Drawing.Size(360, 13);
            this.lblDestHelp.TabIndex = 7;
            this.lblDestHelp.Text = "Where organized folders will be created (leave blank to use source folder)";
            //
            // txtDestinationFolder
            //
            this.txtDestinationFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDestinationFolder.Location = new System.Drawing.Point(15, 118);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(415, 23);
            this.txtDestinationFolder.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDestinationFolder, "Optional: Choose a different destination folder");
            //
            // btnBrowseDestination
            //
            this.btnBrowseDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseDestination.Location = new System.Drawing.Point(436, 117);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(85, 25);
            this.btnBrowseDestination.TabIndex = 6;
            this.btnBrowseDestination.Text = "Browse...";
            this.toolTip1.SetToolTip(this.btnBrowseDestination, "Click to select destination folder");
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            //
            // grpOptions
            //
            this.grpOptions.Controls.Add(this.lblDateFormatHelp);
            this.grpOptions.Controls.Add(this.lblDateFormat);
            this.grpOptions.Controls.Add(this.txtDateFormat);
            this.grpOptions.Controls.Add(this.rbMove);
            this.grpOptions.Controls.Add(this.rbCopy);
            this.grpOptions.Controls.Add(this.chkTouch);
            this.grpOptions.Controls.Add(this.chk_DontMove);
            this.grpOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpOptions.Location = new System.Drawing.Point(580, 100);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpOptions.Size = new System.Drawing.Size(500, 185);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "⚙️ Options";
            //
            // rbMove
            //
            this.rbMove.AutoSize = true;
            this.rbMove.Checked = true;
            this.rbMove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rbMove.Location = new System.Drawing.Point(18, 30);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(91, 19);
            this.rbMove.TabIndex = 0;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move Files";
            this.toolTip1.SetToolTip(this.rbMove, "Move files to organized folders (removes from source)");
            this.rbMove.UseVisualStyleBackColor = true;
            //
            // rbCopy
            //
            this.rbCopy.AutoSize = true;
            this.rbCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rbCopy.Location = new System.Drawing.Point(18, 55);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(87, 19);
            this.rbCopy.TabIndex = 1;
            this.rbCopy.Text = "Copy Files";
            this.toolTip1.SetToolTip(this.rbCopy, "Copy files to organized folders (keeps original)");
            this.rbCopy.UseVisualStyleBackColor = true;
            this.rbCopy.CheckedChanged += new System.EventHandler(this.rbCopy_CheckedChanged);
            //
            // chkTouch
            //
            this.chkTouch.AutoSize = true;
            this.chkTouch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkTouch.Location = new System.Drawing.Point(270, 31);
            this.chkTouch.Name = "chkTouch";
            this.chkTouch.Size = new System.Drawing.Size(201, 19);
            this.chkTouch.TabIndex = 2;
            this.chkTouch.Text = "Update file timestamp to match";
            this.toolTip1.SetToolTip(this.chkTouch, "Sets the file creation time to match the photo\'s DateTaken value");
            this.chkTouch.UseVisualStyleBackColor = true;
            //
            // chk_DontMove
            //
            this.chk_DontMove.AutoSize = true;
            this.chk_DontMove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chk_DontMove.Location = new System.Drawing.Point(270, 56);
            this.chk_DontMove.Name = "chk_DontMove";
            this.chk_DontMove.Size = new System.Drawing.Size(189, 19);
            this.chk_DontMove.TabIndex = 3;
            this.chk_DontMove.Text = "Preview only (don\'t move files)";
            this.toolTip1.SetToolTip(this.chk_DontMove, "Check this to see what would happen without actually moving files");
            this.chk_DontMove.UseVisualStyleBackColor = true;
            //
            // lblDateFormat
            //
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateFormat.Location = new System.Drawing.Point(18, 98);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(129, 15);
            this.lblDateFormat.TabIndex = 4;
            this.lblDateFormat.Text = "Folder Name Format:";
            //
            // txtDateFormat
            //
            this.txtDateFormat.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtDateFormat.Location = new System.Drawing.Point(18, 118);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(200, 22);
            this.txtDateFormat.TabIndex = 5;
            this.txtDateFormat.Text = "yyyy-MM-dd";
            this.toolTip1.SetToolTip(this.txtDateFormat, "Date format for folder names (e.g., yyyy-MM-dd creates 2024-01-15)");
            //
            // lblDateFormatHelp
            //
            this.lblDateFormatHelp.AutoSize = true;
            this.lblDateFormatHelp.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDateFormatHelp.Location = new System.Drawing.Point(18, 145);
            this.lblDateFormatHelp.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDateFormatHelp.Name = "lblDateFormatHelp";
            this.lblDateFormatHelp.Size = new System.Drawing.Size(452, 26);
            this.lblDateFormatHelp.TabIndex = 6;
            this.lblDateFormatHelp.Text = "Examples: yyyy-MM-dd → 2024-01-15  |  yyyy\\\\MM → 2024\\01  |  yyyyMMdd → 20240115\r\nUse \\\\ for subfolders (e.g., yyyy\\\\MM\\\\dd creates year/month/day structure)";
            //
            // grpActions
            //
            this.grpActions.Controls.Add(this.btnPreview);
            this.grpActions.Controls.Add(this.btnMoveFiles);
            this.grpActions.Controls.Add(this.btnClear);
            this.grpActions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpActions.Location = new System.Drawing.Point(20, 300);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpActions.Size = new System.Drawing.Size(1060, 75);
            this.grpActions.TabIndex = 3;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "🚀 Actions";
            //
            // btnPreview
            //
            this.btnPreview.Enabled = false;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPreview.Location = new System.Drawing.Point(18, 28);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(140, 35);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "📋 Preview";
            this.toolTip1.SetToolTip(this.btnPreview, "Scan photos and preview how they will be organized");
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            //
            // btnMoveFiles
            //
            this.btnMoveFiles.Enabled = false;
            this.btnMoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveFiles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMoveFiles.Location = new System.Drawing.Point(170, 28);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(140, 35);
            this.btnMoveFiles.TabIndex = 1;
            this.btnMoveFiles.Text = "✓ Move Files";
            this.toolTip1.SetToolTip(this.btnMoveFiles, "Execute the move/copy operation");
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            //
            // btnClear
            //
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.Location = new System.Drawing.Point(322, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "🗑️ Clear Results";
            this.toolTip1.SetToolTip(this.btnClear, "Clear the preview results");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            //
            // tabControl1
            //
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Controls.Add(this.tabErrors);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(20, 390);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 215);
            this.tabControl1.TabIndex = 4;
            //
            // tabResults
            //
            this.tabResults.Controls.Add(this.gvResults);
            this.tabResults.Location = new System.Drawing.Point(4, 24);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(8);
            this.tabResults.Size = new System.Drawing.Size(1052, 187);
            this.tabResults.TabIndex = 0;
            this.tabResults.Text = "📊 Preview Results";
            this.tabResults.UseVisualStyleBackColor = true;
            //
            // gvResults
            //
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            this.gvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResults.Location = new System.Drawing.Point(8, 8);
            this.gvResults.Name = "gvResults";
            this.gvResults.ReadOnly = true;
            this.gvResults.RowHeadersWidth = 30;
            this.gvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResults.ShowCellToolTips = false;
            this.gvResults.ShowEditingIcon = false;
            this.gvResults.Size = new System.Drawing.Size(1036, 171);
            this.gvResults.TabIndex = 0;
            //
            // tabErrors
            //
            this.tabErrors.Controls.Add(this.lstErrors);
            this.tabErrors.Location = new System.Drawing.Point(4, 24);
            this.tabErrors.Name = "tabErrors";
            this.tabErrors.Padding = new System.Windows.Forms.Padding(8);
            this.tabErrors.Size = new System.Drawing.Size(1052, 187);
            this.tabErrors.TabIndex = 1;
            this.tabErrors.Text = "⚠️ Errors (0)";
            this.tabErrors.UseVisualStyleBackColor = true;
            //
            // lstErrors
            //
            this.lstErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstErrors.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstErrors.FormattingEnabled = true;
            this.lstErrors.ItemHeight = 14;
            this.lstErrors.Location = new System.Drawing.Point(8, 8);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(1036, 171);
            this.lstErrors.TabIndex = 0;
            //
            // statusStrip1
            //
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1100, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            //
            // toolStripStatusLabel
            //
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(883, 20);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Ready";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // toolStripProgressBar
            //
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 19);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            //
            // frmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpFolders);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoMover - Organize Photos by Date";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.tabErrors.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpFolders.ResumeLayout(false);
            this.grpFolders.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.grpActions.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbMove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMove;
        private System.Windows.Forms.CheckBox chkTouch;
        private System.Windows.Forms.CheckBox chk_DontMove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.TabPage tabErrors;
        private System.Windows.Forms.ListBox lstErrors;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpFolders;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppDescription;
        private System.Windows.Forms.Label lblSourceHelp;
        private System.Windows.Forms.Label lblDestHelp;
        private System.Windows.Forms.Label lblDateFormatHelp;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnClear;
    }
}

