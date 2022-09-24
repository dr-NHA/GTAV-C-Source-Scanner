namespace NHA_CScriptScannerUI
{
    partial class ScannerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerUI));
            this.OffsetsSplitter = new System.Windows.Forms.Splitter();
            this.LeftOptionsPanel = new System.Windows.Forms.Panel();
            this.ResultsSplitter = new System.Windows.Forms.SplitContainer();
            this.UploaderPanel = new System.Windows.Forms.Panel();
            this.NHA_INFO = new System.Windows.Forms.RichTextBox();
            this.NGT = new System.Windows.Forms.Button();
            this.MainResultsPanel = new System.Windows.Forms.Panel();
            this.ResultsLines = new System.Windows.Forms.RichTextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GTA_DECOMP_SCRIPTS = new System.Windows.Forms.Button();
            this.BulkCleanerButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OffsetsTab = new System.Windows.Forms.TabPage();
            this.HashesTab = new System.Windows.Forms.TabPage();
            this.Offsets = new System.Windows.Forms.RichTextBox();
            this.OffsetsLabel = new System.Windows.Forms.Label();
            this.HashList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenUploader = new System.Windows.Forms.Button();
            this.LeftOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsSplitter)).BeginInit();
            this.ResultsSplitter.Panel1.SuspendLayout();
            this.ResultsSplitter.Panel2.SuspendLayout();
            this.ResultsSplitter.SuspendLayout();
            this.UploaderPanel.SuspendLayout();
            this.MainResultsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.OffsetsTab.SuspendLayout();
            this.HashesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // OffsetsSplitter
            // 
            this.OffsetsSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.OffsetsSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OffsetsSplitter.Location = new System.Drawing.Point(418, 3);
            this.OffsetsSplitter.MinSize = 416;
            this.OffsetsSplitter.Name = "OffsetsSplitter";
            this.OffsetsSplitter.Size = new System.Drawing.Size(10, 383);
            this.OffsetsSplitter.TabIndex = 5;
            this.OffsetsSplitter.TabStop = false;
            // 
            // LeftOptionsPanel
            // 
            this.LeftOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftOptionsPanel.Controls.Add(this.ResultsSplitter);
            this.LeftOptionsPanel.Controls.Add(this.TopPanel);
            this.LeftOptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftOptionsPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftOptionsPanel.Name = "LeftOptionsPanel";
            this.LeftOptionsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.LeftOptionsPanel.Size = new System.Drawing.Size(415, 383);
            this.LeftOptionsPanel.TabIndex = 9;
            // 
            // ResultsSplitter
            // 
            this.ResultsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsSplitter.Location = new System.Drawing.Point(3, 50);
            this.ResultsSplitter.Name = "ResultsSplitter";
            this.ResultsSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ResultsSplitter.Panel1
            // 
            this.ResultsSplitter.Panel1.Controls.Add(this.UploaderPanel);
            this.ResultsSplitter.Panel1.Controls.Add(this.OpenUploader);
            this.ResultsSplitter.Panel1.Controls.Add(this.NGT);
            this.ResultsSplitter.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.ResultsSplitter.Panel1MinSize = 95;
            // 
            // ResultsSplitter.Panel2
            // 
            this.ResultsSplitter.Panel2.Controls.Add(this.MainResultsPanel);
            this.ResultsSplitter.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.ResultsSplitter.Size = new System.Drawing.Size(407, 328);
            this.ResultsSplitter.SplitterDistance = 153;
            this.ResultsSplitter.SplitterWidth = 8;
            this.ResultsSplitter.TabIndex = 8;
            // 
            // UploaderPanel
            // 
            this.UploaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UploaderPanel.Controls.Add(this.NHA_INFO);
            this.UploaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UploaderPanel.Location = new System.Drawing.Point(3, 3);
            this.UploaderPanel.Name = "UploaderPanel";
            this.UploaderPanel.Padding = new System.Windows.Forms.Padding(3);
            this.UploaderPanel.Size = new System.Drawing.Size(401, 106);
            this.UploaderPanel.TabIndex = 8;
            // 
            // NHA_INFO
            // 
            this.NHA_INFO.BackColor = System.Drawing.Color.Black;
            this.NHA_INFO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NHA_INFO.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHA_INFO.ForeColor = System.Drawing.Color.GreenYellow;
            this.NHA_INFO.Location = new System.Drawing.Point(3, 3);
            this.NHA_INFO.Name = "NHA_INFO";
            this.NHA_INFO.Size = new System.Drawing.Size(393, 98);
            this.NHA_INFO.TabIndex = 11;
            this.NHA_INFO.Text = "";
            this.NHA_INFO.WordWrap = false;
            // 
            // NGT
            // 
            this.NGT.BackColor = System.Drawing.Color.Black;
            this.NGT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NGT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NGT.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGT.ForeColor = System.Drawing.Color.LimeGreen;
            this.NGT.Location = new System.Drawing.Point(3, 130);
            this.NGT.Name = "NGT";
            this.NGT.Size = new System.Drawing.Size(401, 20);
            this.NGT.TabIndex = 11;
            this.NGT.Text = "Network Globals Tester";
            this.NGT.UseVisualStyleBackColor = false;
            // 
            // MainResultsPanel
            // 
            this.MainResultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainResultsPanel.Controls.Add(this.ResultsLines);
            this.MainResultsPanel.Controls.Add(this.ResultsLabel);
            this.MainResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainResultsPanel.Location = new System.Drawing.Point(3, 3);
            this.MainResultsPanel.Name = "MainResultsPanel";
            this.MainResultsPanel.Size = new System.Drawing.Size(401, 161);
            this.MainResultsPanel.TabIndex = 4;
            // 
            // ResultsLines
            // 
            this.ResultsLines.BackColor = System.Drawing.Color.Black;
            this.ResultsLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsLines.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLines.ForeColor = System.Drawing.Color.Lime;
            this.ResultsLines.Location = new System.Drawing.Point(0, 13);
            this.ResultsLines.Name = "ResultsLines";
            this.ResultsLines.ReadOnly = true;
            this.ResultsLines.Size = new System.Drawing.Size(399, 146);
            this.ResultsLines.TabIndex = 2;
            this.ResultsLines.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            this.ResultsLines.WordWrap = false;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultsLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.ResultsLabel.Location = new System.Drawing.Point(0, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(399, 13);
            this.ResultsLabel.TabIndex = 3;
            this.ResultsLabel.Text = "Results Output:";
            this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.tableLayoutPanel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(3);
            this.TopPanel.Size = new System.Drawing.Size(407, 47);
            this.TopPanel.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GTA_DECOMP_SCRIPTS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BulkCleanerButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 41);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // GTA_DECOMP_SCRIPTS
            // 
            this.GTA_DECOMP_SCRIPTS.BackColor = System.Drawing.Color.Black;
            this.GTA_DECOMP_SCRIPTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GTA_DECOMP_SCRIPTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GTA_DECOMP_SCRIPTS.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTA_DECOMP_SCRIPTS.ForeColor = System.Drawing.Color.LimeGreen;
            this.GTA_DECOMP_SCRIPTS.Location = new System.Drawing.Point(203, 3);
            this.GTA_DECOMP_SCRIPTS.Name = "GTA_DECOMP_SCRIPTS";
            this.GTA_DECOMP_SCRIPTS.Size = new System.Drawing.Size(195, 35);
            this.GTA_DECOMP_SCRIPTS.TabIndex = 6;
            this.GTA_DECOMP_SCRIPTS.Text = "Open Script Downloader";
            this.GTA_DECOMP_SCRIPTS.UseVisualStyleBackColor = false;
            // 
            // BulkCleanerButton
            // 
            this.BulkCleanerButton.BackColor = System.Drawing.Color.Black;
            this.BulkCleanerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BulkCleanerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BulkCleanerButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulkCleanerButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.BulkCleanerButton.Location = new System.Drawing.Point(3, 3);
            this.BulkCleanerButton.Name = "BulkCleanerButton";
            this.BulkCleanerButton.Size = new System.Drawing.Size(194, 35);
            this.BulkCleanerButton.TabIndex = 5;
            this.BulkCleanerButton.Text = "Open Bulk Cleaner";
            this.BulkCleanerButton.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OffsetsTab);
            this.tabControl1.Controls.Add(this.HashesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(428, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(274, 383);
            this.tabControl1.TabIndex = 10;
            // 
            // OffsetsTab
            // 
            this.OffsetsTab.BackColor = System.Drawing.Color.Black;
            this.OffsetsTab.Controls.Add(this.Offsets);
            this.OffsetsTab.Controls.Add(this.OffsetsLabel);
            this.OffsetsTab.ForeColor = System.Drawing.Color.Chartreuse;
            this.OffsetsTab.Location = new System.Drawing.Point(4, 22);
            this.OffsetsTab.Name = "OffsetsTab";
            this.OffsetsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OffsetsTab.Size = new System.Drawing.Size(266, 357);
            this.OffsetsTab.TabIndex = 0;
            this.OffsetsTab.Text = "Offsets";
            // 
            // HashesTab
            // 
            this.HashesTab.BackColor = System.Drawing.Color.Black;
            this.HashesTab.Controls.Add(this.HashList);
            this.HashesTab.Controls.Add(this.label1);
            this.HashesTab.ForeColor = System.Drawing.Color.Chartreuse;
            this.HashesTab.Location = new System.Drawing.Point(4, 22);
            this.HashesTab.Name = "HashesTab";
            this.HashesTab.Padding = new System.Windows.Forms.Padding(3);
            this.HashesTab.Size = new System.Drawing.Size(266, 357);
            this.HashesTab.TabIndex = 1;
            this.HashesTab.Text = "Hashes";
            // 
            // Offsets
            // 
            this.Offsets.BackColor = System.Drawing.Color.Black;
            this.Offsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Offsets.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Offsets.ForeColor = System.Drawing.Color.Lime;
            this.Offsets.Location = new System.Drawing.Point(3, 16);
            this.Offsets.Name = "Offsets";
            this.Offsets.ReadOnly = true;
            this.Offsets.Size = new System.Drawing.Size(260, 338);
            this.Offsets.TabIndex = 6;
            this.Offsets.Text = "";
            this.Offsets.WordWrap = false;
            // 
            // OffsetsLabel
            // 
            this.OffsetsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OffsetsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffsetsLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetsLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.OffsetsLabel.Location = new System.Drawing.Point(3, 3);
            this.OffsetsLabel.Name = "OffsetsLabel";
            this.OffsetsLabel.Size = new System.Drawing.Size(260, 13);
            this.OffsetsLabel.TabIndex = 7;
            this.OffsetsLabel.Text = "Offsets::";
            this.OffsetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HashList
            // 
            this.HashList.BackColor = System.Drawing.Color.Black;
            this.HashList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HashList.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashList.ForeColor = System.Drawing.Color.Lime;
            this.HashList.Location = new System.Drawing.Point(3, 16);
            this.HashList.Name = "HashList";
            this.HashList.ReadOnly = true;
            this.HashList.Size = new System.Drawing.Size(260, 338);
            this.HashList.TabIndex = 9;
            this.HashList.Text = "";
            this.HashList.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hashes::";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpenUploader
            // 
            this.OpenUploader.BackColor = System.Drawing.Color.Black;
            this.OpenUploader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpenUploader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenUploader.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenUploader.ForeColor = System.Drawing.Color.LimeGreen;
            this.OpenUploader.Location = new System.Drawing.Point(3, 109);
            this.OpenUploader.Name = "OpenUploader";
            this.OpenUploader.Size = new System.Drawing.Size(401, 21);
            this.OpenUploader.TabIndex = 13;
            this.OpenUploader.Text = "Open Uploader";
            this.OpenUploader.UseVisualStyleBackColor = false;
            // 
            // ScannerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(705, 389);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OffsetsSplitter);
            this.Controls.Add(this.LeftOptionsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(610, 250);
            this.Name = "ScannerUI";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "NHA\'s C Script Cleaner And Scanner";
            this.LeftOptionsPanel.ResumeLayout(false);
            this.ResultsSplitter.Panel1.ResumeLayout(false);
            this.ResultsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsSplitter)).EndInit();
            this.ResultsSplitter.ResumeLayout(false);
            this.UploaderPanel.ResumeLayout(false);
            this.MainResultsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.OffsetsTab.ResumeLayout(false);
            this.HashesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter OffsetsSplitter;
        private System.Windows.Forms.Panel LeftOptionsPanel;
        private System.Windows.Forms.SplitContainer ResultsSplitter;
        private System.Windows.Forms.Panel UploaderPanel;
        private System.Windows.Forms.RichTextBox NHA_INFO;
        private System.Windows.Forms.Button NGT;
        private System.Windows.Forms.Panel MainResultsPanel;
        private System.Windows.Forms.RichTextBox ResultsLines;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GTA_DECOMP_SCRIPTS;
        private System.Windows.Forms.Button BulkCleanerButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OffsetsTab;
        private System.Windows.Forms.RichTextBox Offsets;
        private System.Windows.Forms.Label OffsetsLabel;
        private System.Windows.Forms.TabPage HashesTab;
        private System.Windows.Forms.RichTextBox HashList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenUploader;
    }
}

