namespace NHA_CScriptScannerUI
{
    partial class BulkCleanerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkCleanerUI));
            this.ScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.FindCFiles = new System.Windows.Forms.Button();
            this.ScriptsToClean = new System.Windows.Forms.ListBox();
            this.DoCleanButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TopBar = new System.Windows.Forms.Panel();
            this.DoHashScan = new System.Windows.Forms.Button();
            this.StatusX = new System.Windows.Forms.ListBox();
            this.CleanAndScan = new System.Windows.Forms.Button();
            this.OpenWithNotePad = new System.Windows.Forms.Button();
            this.TopBar2 = new System.Windows.Forms.Panel();
            this.FixNativesButton = new System.Windows.Forms.Button();
            this.ClearScriptsToClean = new System.Windows.Forms.Button();
            this.DoScanAll = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.TopBar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScriptDialog
            // 
            this.ScriptDialog.DefaultExt = "c";
            this.ScriptDialog.FileName = "Open Your C Scripts";
            this.ScriptDialog.Filter = "C Scripts|*.c";
            this.ScriptDialog.Multiselect = true;
            this.ScriptDialog.Title = "Open Your C Scripts";
            // 
            // FindCFiles
            // 
            this.FindCFiles.BackColor = System.Drawing.Color.Black;
            this.FindCFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.FindCFiles.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.FindCFiles.FlatAppearance.BorderSize = 3;
            this.FindCFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindCFiles.ForeColor = System.Drawing.Color.Lime;
            this.FindCFiles.Location = new System.Drawing.Point(3, 3);
            this.FindCFiles.Name = "FindCFiles";
            this.FindCFiles.Size = new System.Drawing.Size(79, 28);
            this.FindCFiles.TabIndex = 0;
            this.FindCFiles.Text = "Open Files";
            this.FindCFiles.UseVisualStyleBackColor = false;
            // 
            // ScriptsToClean
            // 
            this.ScriptsToClean.BackColor = System.Drawing.Color.Black;
            this.ScriptsToClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptsToClean.ForeColor = System.Drawing.Color.Lime;
            this.ScriptsToClean.FormattingEnabled = true;
            this.ScriptsToClean.HorizontalScrollbar = true;
            this.ScriptsToClean.Location = new System.Drawing.Point(3, 133);
            this.ScriptsToClean.Name = "ScriptsToClean";
            this.ScriptsToClean.ScrollAlwaysVisible = true;
            this.ScriptsToClean.Size = new System.Drawing.Size(664, 207);
            this.ScriptsToClean.TabIndex = 1;
            // 
            // DoCleanButton
            // 
            this.DoCleanButton.BackColor = System.Drawing.Color.Black;
            this.DoCleanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoCleanButton.FlatAppearance.BorderSize = 3;
            this.DoCleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoCleanButton.ForeColor = System.Drawing.Color.Lime;
            this.DoCleanButton.Location = new System.Drawing.Point(82, 3);
            this.DoCleanButton.Name = "DoCleanButton";
            this.DoCleanButton.Size = new System.Drawing.Size(489, 28);
            this.DoCleanButton.TabIndex = 3;
            this.DoCleanButton.Text = "Start Clean";
            this.DoCleanButton.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(667, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 337);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.Controls.Add(this.DoCleanButton);
            this.TopBar.Controls.Add(this.DoHashScan);
            this.TopBar.Controls.Add(this.FindCFiles);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(3, 3);
            this.TopBar.Name = "TopBar";
            this.TopBar.Padding = new System.Windows.Forms.Padding(3);
            this.TopBar.Size = new System.Drawing.Size(664, 34);
            this.TopBar.TabIndex = 7;
            // 
            // DoHashScan
            // 
            this.DoHashScan.BackColor = System.Drawing.Color.Black;
            this.DoHashScan.Dock = System.Windows.Forms.DockStyle.Right;
            this.DoHashScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DoHashScan.FlatAppearance.BorderSize = 3;
            this.DoHashScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoHashScan.ForeColor = System.Drawing.Color.Lime;
            this.DoHashScan.Location = new System.Drawing.Point(571, 3);
            this.DoHashScan.Name = "DoHashScan";
            this.DoHashScan.Size = new System.Drawing.Size(90, 28);
            this.DoHashScan.TabIndex = 6;
            this.DoHashScan.Text = "Hash Scan";
            this.DoHashScan.UseVisualStyleBackColor = false;
            // 
            // StatusX
            // 
            this.StatusX.BackColor = System.Drawing.Color.Black;
            this.StatusX.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusX.ForeColor = System.Drawing.Color.Lime;
            this.StatusX.FormattingEnabled = true;
            this.StatusX.HorizontalScrollbar = true;
            this.StatusX.Location = new System.Drawing.Point(677, 3);
            this.StatusX.Name = "StatusX";
            this.StatusX.Size = new System.Drawing.Size(312, 337);
            this.StatusX.TabIndex = 8;
            this.StatusX.DoubleClick += new System.EventHandler(this.StatusX_DoubleClick);
            // 
            // CleanAndScan
            // 
            this.CleanAndScan.BackColor = System.Drawing.Color.Black;
            this.CleanAndScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.CleanAndScan.FlatAppearance.BorderSize = 3;
            this.CleanAndScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanAndScan.ForeColor = System.Drawing.Color.Lime;
            this.CleanAndScan.Location = new System.Drawing.Point(3, 71);
            this.CleanAndScan.Name = "CleanAndScan";
            this.CleanAndScan.Size = new System.Drawing.Size(664, 31);
            this.CleanAndScan.TabIndex = 11;
            this.CleanAndScan.Text = "Start Clean And Scan";
            this.CleanAndScan.UseVisualStyleBackColor = false;
            // 
            // OpenWithNotePad
            // 
            this.OpenWithNotePad.BackColor = System.Drawing.Color.Black;
            this.OpenWithNotePad.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenWithNotePad.FlatAppearance.BorderSize = 3;
            this.OpenWithNotePad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenWithNotePad.ForeColor = System.Drawing.Color.Lime;
            this.OpenWithNotePad.Location = new System.Drawing.Point(3, 102);
            this.OpenWithNotePad.Name = "OpenWithNotePad";
            this.OpenWithNotePad.Size = new System.Drawing.Size(664, 31);
            this.OpenWithNotePad.TabIndex = 12;
            this.OpenWithNotePad.Text = "Open Already Compatible Scripts With Notepad++";
            this.OpenWithNotePad.UseVisualStyleBackColor = false;
            // 
            // TopBar2
            // 
            this.TopBar2.Controls.Add(this.DoScanAll);
            this.TopBar2.Controls.Add(this.ClearScriptsToClean);
            this.TopBar2.Controls.Add(this.FixNativesButton);
            this.TopBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar2.Location = new System.Drawing.Point(3, 37);
            this.TopBar2.Name = "TopBar2";
            this.TopBar2.Padding = new System.Windows.Forms.Padding(3);
            this.TopBar2.Size = new System.Drawing.Size(664, 34);
            this.TopBar2.TabIndex = 13;
            // 
            // FixNativesButton
            // 
            this.FixNativesButton.BackColor = System.Drawing.Color.Black;
            this.FixNativesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FixNativesButton.FlatAppearance.BorderSize = 3;
            this.FixNativesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixNativesButton.ForeColor = System.Drawing.Color.Lime;
            this.FixNativesButton.Location = new System.Drawing.Point(3, 3);
            this.FixNativesButton.Name = "FixNativesButton";
            this.FixNativesButton.Size = new System.Drawing.Size(79, 28);
            this.FixNativesButton.TabIndex = 9;
            this.FixNativesButton.Text = "Fix Natives";
            this.FixNativesButton.UseVisualStyleBackColor = false;
            // 
            // ClearScriptsToClean
            // 
            this.ClearScriptsToClean.BackColor = System.Drawing.Color.Black;
            this.ClearScriptsToClean.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearScriptsToClean.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ClearScriptsToClean.FlatAppearance.BorderSize = 2;
            this.ClearScriptsToClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearScriptsToClean.ForeColor = System.Drawing.Color.Lime;
            this.ClearScriptsToClean.Location = new System.Drawing.Point(571, 3);
            this.ClearScriptsToClean.Name = "ClearScriptsToClean";
            this.ClearScriptsToClean.Size = new System.Drawing.Size(90, 28);
            this.ClearScriptsToClean.TabIndex = 10;
            this.ClearScriptsToClean.Text = "Clear Scripts";
            this.ClearScriptsToClean.UseVisualStyleBackColor = false;
            // 
            // DoScanAll
            // 
            this.DoScanAll.BackColor = System.Drawing.Color.Black;
            this.DoScanAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoScanAll.FlatAppearance.BorderSize = 3;
            this.DoScanAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoScanAll.ForeColor = System.Drawing.Color.Lime;
            this.DoScanAll.Location = new System.Drawing.Point(82, 3);
            this.DoScanAll.Name = "DoScanAll";
            this.DoScanAll.Size = new System.Drawing.Size(489, 28);
            this.DoScanAll.TabIndex = 11;
            this.DoScanAll.Text = "Start Scan";
            this.DoScanAll.UseVisualStyleBackColor = false;
            // 
            // BulkCleanerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(992, 343);
            this.Controls.Add(this.ScriptsToClean);
            this.Controls.Add(this.OpenWithNotePad);
            this.Controls.Add(this.CleanAndScan);
            this.Controls.Add(this.TopBar2);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.StatusX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 200);
            this.Name = "BulkCleanerUI";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "BulkCleanerUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.TopBar.ResumeLayout(false);
            this.TopBar2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ScriptDialog;
        private System.Windows.Forms.Button FindCFiles;
        private System.Windows.Forms.ListBox ScriptsToClean;
        private System.Windows.Forms.Button DoCleanButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.ListBox StatusX;
        private System.Windows.Forms.Button CleanAndScan;
        private System.Windows.Forms.Button DoHashScan;
        private System.Windows.Forms.Button OpenWithNotePad;
        private System.Windows.Forms.Panel TopBar2;
        private System.Windows.Forms.Button DoScanAll;
        private System.Windows.Forms.Button ClearScriptsToClean;
        private System.Windows.Forms.Button FixNativesButton;
    }
}