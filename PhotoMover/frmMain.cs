using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoMover
{
    public partial class frmMain : Form
    {
        const int propertyTagExifDTOrig_ = 0x9003; //36867;
        List<ItemToMove> items = new List<ItemToMove>();
        List<string> errorMessages = new List<string>(); // Thread-safe error collection

        public frmMain()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            toolStripStatusLabel.Text = "Ready";
            toolStripProgressBar.Visible = false;

            // Apply theme after all controls are initialized
            ApplyTheme();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Apply dark title bar if in dark mode
            if (ThemeManager.CurrentMode == ThemeMode.Dark)
            {
                DwmHelper.UseImmersiveDarkMode(this.Handle, true);
            }
        }

        private void ApplyTheme()
        {
            AppTheme theme = ThemeManager.GetCurrentTheme();

            // Form
            this.BackColor = theme.FormBackground;

            // Header Panel
            panelHeader.BackColor = theme.HeaderBackground;
            lblAppTitle.ForeColor = theme.HeaderText;
            lblAppDescription.ForeColor = theme.HeaderSubtext;

            // Group Boxes
            ApplyGroupBoxTheme(grpFolders, theme);
            ApplyGroupBoxTheme(grpOptions, theme);
            ApplyGroupBoxTheme(grpActions, theme);

            // Status Bar
            statusStrip1.BackColor = theme.StatusBarBack;
            toolStripStatusLabel.ForeColor = theme.StatusBarText;

            // Tab Control
            tabControl1.SetTheme(theme);
            ApplyTabTheme(tabResults, theme);
            ApplyTabTheme(tabErrors, theme);

            // Data Grid
            ApplyDataGridTheme(gvResults, theme);

            // Error List
            lstErrors.BackColor = theme.ControlBackground;
            lstErrors.ForeColor = theme.ControlText;
        }

        private void ApplyGroupBoxTheme(GroupBox group, AppTheme theme)
        {
            group.BackColor = theme.FormBackground;
            group.ForeColor = theme.GroupBoxText;

            // Enable custom painting for group boxes
            group.Paint -= GroupBox_Paint; // Remove if already added
            group.Paint += GroupBox_Paint;

            foreach (Control ctrl in group.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.BackColor = theme.ControlBackground;
                    textBox.ForeColor = theme.ControlText;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is Button btn)
                {
                    ApplyButtonTheme(btn, theme);
                }
                else if (ctrl is Label label)
                {
                    label.BackColor = Color.Transparent;
                    // Check if it's a help label by font size
                    if (label.Font.Size <= 8.5f)
                    {
                        label.ForeColor = theme.HelpText;
                    }
                    else
                    {
                        label.ForeColor = theme.ControlText;
                    }
                }
                else if (ctrl is CheckBox || ctrl is RadioButton)
                {
                    ctrl.BackColor = Color.Transparent;
                    ctrl.ForeColor = theme.ControlText;
                }
            }
        }

        private void GroupBox_Paint(object? sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender!;
            AppTheme theme = ThemeManager.GetCurrentTheme();

            Graphics g = e.Graphics;
            g.Clear(theme.FormBackground);

            // Measure text
            SizeF textSize = g.MeasureString(box.Text, box.Font);
            int textPadding = 8;

            // Draw border
            int borderY = (int)(textSize.Height / 2);
            Rectangle borderRect = new Rectangle(0, borderY, box.Width - 1, box.Height - borderY - 1);

            using (Pen borderPen = new Pen(theme.BorderColor, 1))
            {
                g.DrawRectangle(borderPen, borderRect);
            }

            // Draw text background
            Rectangle textBackRect = new Rectangle(8, 0, (int)textSize.Width + textPadding * 2, (int)textSize.Height);
            using (SolidBrush backBrush = new SolidBrush(theme.FormBackground))
            {
                g.FillRectangle(backBrush, textBackRect);
            }

            // Draw text
            using (SolidBrush textBrush = new SolidBrush(theme.GroupBoxText))
            {
                g.DrawString(box.Text, box.Font, textBrush, 8 + textPadding, 0);
            }
        }

        private void ApplyButtonTheme(Button btn, AppTheme theme)
        {
            // Determine button type by name or text
            if (btn == btnPreview)
            {
                btn.BackColor = theme.ButtonPrimary;
                btn.ForeColor = theme.ButtonPrimaryText;
            }
            else if (btn == btnMoveFiles)
            {
                btn.BackColor = theme.ButtonSecondary;
                btn.ForeColor = theme.ButtonSecondaryText;
            }
            else if (btn == btnClear)
            {
                btn.BackColor = theme.ButtonDefault;
                btn.ForeColor = theme.ButtonDefaultText;
            }
            else if (btn == btnBrowseSource || btn == btnBrowseDestination)
            {
                btn.BackColor = theme.ButtonDefault;
                btn.ForeColor = theme.ButtonDefaultText;
            }

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = theme.BorderColor;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void ApplyTabTheme(TabPage tab, AppTheme theme)
        {
            tab.BackColor = theme.ControlBackground;
            tab.ForeColor = theme.ControlText;
        }

        private void ApplyDataGridTheme(DataGridView grid, AppTheme theme)
        {
            grid.BackgroundColor = theme.GridBackground;
            grid.GridColor = theme.BorderColor;
            grid.ForeColor = theme.ControlText;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = theme.GridHeaderBack;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = theme.GridHeaderText;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme.GridHeaderBack;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = theme.GridHeaderText;

            grid.DefaultCellStyle.BackColor = theme.GridBackground;
            grid.DefaultCellStyle.ForeColor = theme.ControlText;
            grid.DefaultCellStyle.SelectionBackColor = theme.ButtonPrimary;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.AlternatingRowsDefaultCellStyle.BackColor = theme.GridAlternateRow;
            grid.AlternatingRowsDefaultCellStyle.ForeColor = theme.ControlText;

            grid.RowHeadersDefaultCellStyle.BackColor = theme.GridHeaderBack;
            grid.RowHeadersDefaultCellStyle.ForeColor = theme.GridHeaderText;
        }



        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork!);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted!);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged!);

            // Initialize move background worker
            backgroundWorkerMove.WorkerReportsProgress = true;
            backgroundWorkerMove.WorkerSupportsCancellation = true;
            backgroundWorkerMove.DoWork += new DoWorkEventHandler(backgroundWorkerMove_DoWork!);
            backgroundWorkerMove.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerMove_RunWorkerCompleted!);
            backgroundWorkerMove.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerMove_ProgressChanged!);
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            if (fbSourceFolder.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = fbSourceFolder.SelectedPath;
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            if (fbDestinationBrowser.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = fbDestinationBrowser.SelectedPath;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Issue #5: Validate source folder exists
                if (string.IsNullOrWhiteSpace(txtSourceFolder.Text))
                {
                    MessageBox.Show("Please select a source folder.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!System.IO.Directory.Exists(txtSourceFolder.Text))
                {
                    MessageBox.Show("Source folder does not exist.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Issue #6: Validate date format
                if (!IsValidDateFormat(txtDateFormat.Text))
                {
                    MessageBox.Show("Invalid date format. Please use a valid .NET date format string.\n\n" +
                        "Examples:\n" +
                        "  yyyy-MM-dd\n" +
                        "  yyyy\\\\MM\\\\dd\n" +
                        "  yyyy-MM\n" +
                        "  yyyyMMdd",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtDestinationFolder.Text))
                {
                    txtDestinationFolder.Text = txtSourceFolder.Text;
                }

                toolStripStatusLabel.Text = "Scanning photos...";
                toolStripProgressBar.Value = 0;
                toolStripProgressBar.Visible = true;
                gvResults.DataSource = null;
                tabControl1.SelectedIndex = 0;
                tabControl1.TabPages[1].Text = "Errors (0)";
                lstErrors.Items.Clear();
                errorMessages.Clear();
                btnMoveFiles.Enabled = false; // Disable until preview completes
                backgroundWorker1.RunWorkerAsync();
            }
            else if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        // Issue #6: Validate date format string
        private bool IsValidDateFormat(string format)
        {
            if (string.IsNullOrWhiteSpace(format))
                return false;

            try
            {
                // Test the format with a known date
                DateTime testDate = new DateTime(2020, 1, 15);
                string result = testDate.ToString(format);

                // Check for invalid path characters
                char[] invalidChars = Path.GetInvalidFileNameChars();
                // Allow backslash for folder separators
                invalidChars = invalidChars.Where(c => c != '\\').ToArray();

                if (result.IndexOfAny(invalidChars) >= 0)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void backgroundWorker1_DoWork(object? sender, DoWorkEventArgs e)
        {
            BackgroundWorker? worker = sender as BackgroundWorker;
            if (worker == null) return;
            string[] files = System.IO.Directory.GetFiles(txtSourceFolder.Text);
            int counter = 0;
            int total = files.Count();
            items = new List<ItemToMove>();

            // Issue #7: Handle empty folder (division by zero)
            if (total == 0)
            {
                worker.ReportProgress(100);
                return;
            }

            foreach (string file in files)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Issue #1 & #4: GetDateTaken now handles errors internally and adds to errorMessages list
                    DateTime? dateTaken = GetDateTaken(file);

                    if (dateTaken.HasValue)
                    {
                        string filename = Path.GetFileName(file);
                        ItemToMove item = new ItemToMove();
                        item.dataTaken = dateTaken.Value.ToString(txtDateFormat.Text);
                        item.sourceFilename = file;
                        item.destinationFilename = $"{txtDestinationFolder.Text}\\{item.dataTaken}\\{filename}";
                        item.format = Path.GetExtension(filename).ToUpper().TrimStart('.');
                        item.fullDate = dateTaken.Value;
                        items.Add(item);
                    }
                }

                counter++;
                var percent = Decimal.Divide(counter, total) * 100;
                worker.ReportProgress(Convert.ToInt32(percent));
            }
        }

        private void backgroundWorker1_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.Value = e.ProgressPercentage;
            toolStripStatusLabel.Text = string.Format("Scanning photos... {0}%", e.ProgressPercentage);

            // Issue #1: Update errors on UI thread
            if (errorMessages.Count > lstErrors.Items.Count)
            {
                // Add new error messages to the UI
                for (int i = lstErrors.Items.Count; i < errorMessages.Count; i++)
                {
                    lstErrors.Items.Add(errorMessages[i]);
                }
            }

            tabControl1.TabPages[1].Text = string.Format("Errors ({0})", lstErrors.Items.Count);
        }

        private void backgroundWorker1_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar.Visible = false;

            // Issue #1: Final update of error messages
            if (errorMessages.Count > lstErrors.Items.Count)
            {
                for (int i = lstErrors.Items.Count; i < errorMessages.Count; i++)
                {
                    lstErrors.Items.Add(errorMessages[i]);
                }
            }
            tabControl1.TabPages[1].Text = string.Format("Errors ({0})", lstErrors.Items.Count);

            if (items.Count > 0)
            {
                gvResults.DataSource = items;
                gvResults.AutoResizeColumns();
                btnMoveFiles.Enabled = true;
                toolStripStatusLabel.Text = string.Format("Preview complete: {0} file(s) found", items.Count);
            }
            else
            {
                toolStripStatusLabel.Text = "No files with valid date metadata found";
                MessageBox.Show("No files with valid date metadata found.", "Preview Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DateTime? GetDateTaken(string filename)
        {
            string dateTakenText = string.Empty;
            string ext = Path.GetExtension(filename).ToLower();

            try
            {
                if ((ext == ".jpg") || (ext == ".jpeg"))
                {
                    // Issue #4: Properly dispose Image to prevent file locking
                    Image? photo = null;
                    try
                    {
                        photo = Image.FromFile(filename);
                        PropertyItem? pi = photo.GetPropertyItem(propertyTagExifDTOrig_);
                        if (pi != null && pi.Value != null)
                        {
                            ASCIIEncoding enc = new ASCIIEncoding();
                            dateTakenText = enc.GetString(pi.Value, 0, pi.Len - 1);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Issue #1: Add to thread-safe collection instead of directly to UI
                        errorMessages.Add(string.Format("{0} ({1})", ex.Message, Path.GetFileName(filename)));
                    }
                    finally
                    {
                        // Ensure image is disposed even if exception occurs
                        if (photo != null)
                        {
                            photo.Dispose();
                        }
                    }

                    if (!string.IsNullOrEmpty(dateTakenText))
                    {
                        DateTime dateTaken;
                        if (DateTime.TryParseExact(dateTakenText, "yyyy:MM:dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTaken))
                        {
                            return dateTaken;
                        }
                    }
                }
                else if (ext == ".cr2")
                {
                    var directories = ImageMetadataReader.ReadMetadata(filename);
                    var directory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();

                    if (directory == null)
                        return null;

                    if (directory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out var dateTime))
                        return dateTime;
                }
            }
            catch (Exception ex)
            {
                // Issue #1: Thread-safe error logging
                errorMessages.Add(string.Format("Error reading {0}: {1}", Path.GetFileName(filename), ex.Message));
            }

            return null;
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            // Issue #2: Move file operations to background worker
            if (backgroundWorkerMove.IsBusy)
            {
                MessageBox.Show("A move/copy operation is already in progress.", "Busy",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the operation
            string operation = rbMove.Checked ? "move" : "copy";
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {operation} {items.Count} file(s)?",
                $"Confirm {operation}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                btnMoveFiles.Enabled = false;
                btnPreview.Enabled = false;
                toolStripStatusLabel.Text = "Processing files...";
                toolStripProgressBar.Value = 0;
                toolStripProgressBar.Visible = true;
                errorMessages.Clear();
                backgroundWorkerMove.RunWorkerAsync();
            }
        }

        // Issue #2, #3, #8, #9: Background worker for move/copy operations
        private void backgroundWorkerMove_DoWork(object? sender, DoWorkEventArgs e)
        {
            BackgroundWorker? worker = sender as BackgroundWorker;
            if (worker == null) return;
            int counter = 0;
            int total = items.Count;
            int successCount = 0;
            int skipCount = 0;
            int errorCount = 0;

            if (total == 0)
            {
                worker.ReportProgress(100);
                return;
            }

            bool shouldMove = false;
            bool shouldTouch = false;
            bool dontMove = false;

            // Get UI settings on UI thread (via Invoke)
            this.Invoke((MethodInvoker)delegate
            {
                shouldMove = rbMove.Checked;
                shouldTouch = chkTouch.Checked;
                dontMove = chk_DontMove.Checked;
            });

            foreach (ItemToMove item in items)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                try
                {
                    // Issue #9: Safe access to item properties (null check done by foreach)
                    string source = item.sourceFilename;
                    string destination = item.destinationFilename;
                    string datetime = item.fullDate.ToString();

                    string? folder = Path.GetDirectoryName(destination);

                    // Create destination folder if needed
                    if (!string.IsNullOrEmpty(folder) && !System.IO.Directory.Exists(folder))
                    {
                        System.IO.Directory.CreateDirectory(folder);
                    }

                    bool fileWasProcessed = false;

                    // Issue #3: Track whether file was actually moved/copied
                    if (!dontMove)
                    {
                        if (File.Exists(destination))
                        {
                            skipCount++;
                            errorMessages.Add(string.Format("Skipped (already exists): {0}", Path.GetFileName(destination)));
                        }
                        else
                        {
                            if (shouldMove)
                            {
                                File.Move(source, destination);
                                fileWasProcessed = true;
                                successCount++;
                            }
                            else // Copy
                            {
                                File.Copy(source, destination);
                                fileWasProcessed = true;
                                successCount++;
                            }
                        }
                    }
                    else
                    {
                        // Preview mode - just check if destination would exist
                        fileWasProcessed = File.Exists(destination);
                    }

                    // Issue #3: Only touch files that were actually moved/copied or exist
                    if (shouldTouch && fileWasProcessed && File.Exists(destination))
                    {
                        File.SetCreationTime(destination, item.fullDate);
                    }
                }
                catch (Exception ex)
                {
                    // Issue #8: Proper error handling for each file
                    errorCount++;
                    errorMessages.Add(string.Format("Error processing {0}: {1}",
                        Path.GetFileName(item.sourceFilename), ex.Message));
                }

                counter++;
                int percent = (int)((counter / (double)total) * 100);
                worker.ReportProgress(percent, new MoveProgress
                {
                    Processed = counter,
                    Total = total,
                    Success = successCount,
                    Skipped = skipCount,
                    Errors = errorCount
                });
            }

            // Store final counts in result
            e.Result = new MoveProgress
            {
                Processed = counter,
                Total = total,
                Success = successCount,
                Skipped = skipCount,
                Errors = errorCount
            };
        }

        private void backgroundWorkerMove_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            MoveProgress? progress = e.UserState as MoveProgress;
            if (progress != null)
            {
                toolStripProgressBar.Value = Math.Min((progress.Processed * 100) / progress.Total, 100);
                toolStripStatusLabel.Text = string.Format("Processing: {0}/{1} (Success: {2}, Skipped: {3}, Errors: {4})",
                    progress.Processed, progress.Total, progress.Success, progress.Skipped, progress.Errors);
            }

            // Update error list
            if (errorMessages.Count > lstErrors.Items.Count)
            {
                for (int i = lstErrors.Items.Count; i < errorMessages.Count; i++)
                {
                    lstErrors.Items.Add(errorMessages[i]);
                }
                tabControl1.TabPages[1].Text = string.Format("Errors ({0})", lstErrors.Items.Count);
            }
        }

        private void backgroundWorkerMove_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            btnPreview.Enabled = true;
            toolStripProgressBar.Visible = false;

            MoveProgress? finalProgress = e.Result as MoveProgress;
            if (finalProgress != null)
            {
                toolStripStatusLabel.Text = string.Format("Complete: {0} succeeded, {1} skipped, {2} errors",
                    finalProgress.Success, finalProgress.Skipped, finalProgress.Errors);

                string operation = rbMove.Checked ? "moved" : "copied";
                MessageBox.Show(
                    string.Format("Operation complete!\n\n" +
                        "Successfully {0}: {1}\n" +
                        "Skipped: {2}\n" +
                        "Errors: {3}",
                        operation, finalProgress.Success, finalProgress.Skipped, finalProgress.Errors),
                    "Operation Complete",
                    MessageBoxButtons.OK,
                    finalProgress.Errors > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
            }
            else
            {
                toolStripStatusLabel.Text = "Operation cancelled or failed";
            }

            // Update final error list
            if (errorMessages.Count > lstErrors.Items.Count)
            {
                for (int i = lstErrors.Items.Count; i < errorMessages.Count; i++)
                {
                    lstErrors.Items.Add(errorMessages[i]);
                }
                tabControl1.TabPages[1].Text = string.Format("Errors ({0})", lstErrors.Items.Count);
            }

            // Don't re-enable move button - user should preview again after moving
        }

        private void rbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopy.Checked)
                btnMoveFiles.Text = "Copy Files";
            else if (rbMove.Checked)
                btnMoveFiles.Text = "Move Files";
        }

        private void TxtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            btnPreview.Enabled = !string.IsNullOrEmpty(txtSourceFolder.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gvResults.DataSource = null;
            lstErrors.Items.Clear();
            errorMessages.Clear();
            items.Clear();
            btnMoveFiles.Enabled = false;
            tabControl1.TabPages[1].Text = "Errors (0)";
            tabControl1.SelectedIndex = 0;
            toolStripStatusLabel.Text = "Ready";
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = false;
        }
    }

    public class ItemToMove
    {
        [DisplayName("Source")]
        public string sourceFilename { get; set; } = string.Empty;

        [DisplayName("Format")]
        public string format { get; set; } = string.Empty;

        [DisplayName("Date Taken")]
        public string dataTaken { get; set; } = string.Empty;

        [DisplayName("Destination")]
        public string destinationFilename { get; set; } = string.Empty;

        public DateTime fullDate { get; set; }
    }

    // Helper class for move operation progress tracking
    public class MoveProgress
    {
        public int Processed { get; set; }
        public int Total { get; set; }
        public int Success { get; set; }
        public int Skipped { get; set; }
        public int Errors { get; set; }
    }
}
