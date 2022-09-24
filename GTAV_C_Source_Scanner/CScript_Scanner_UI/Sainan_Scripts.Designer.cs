namespace NHA_CScriptScannerUI
{
    partial class Sainan_Scripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sainan_Scripts));
            this.LatestDownload = new System.Windows.Forms.Button();
            this.DownloadedList = new System.Windows.Forms.RichTextBox();
            this.BuildName = new System.Windows.Forms.TextBox();
            this.GameVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DownloadList = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LatestDownload
            // 
            this.LatestDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LatestDownload.FlatAppearance.BorderSize = 2;
            this.LatestDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LatestDownload.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestDownload.ForeColor = System.Drawing.Color.PaleGreen;
            this.LatestDownload.Location = new System.Drawing.Point(6, 6);
            this.LatestDownload.Name = "LatestDownload";
            this.LatestDownload.Size = new System.Drawing.Size(191, 42);
            this.LatestDownload.TabIndex = 0;
            this.LatestDownload.Text = "Get Latest Info";
            this.LatestDownload.UseVisualStyleBackColor = true;
            // 
            // DownloadedList
            // 
            this.DownloadedList.BackColor = System.Drawing.Color.Black;
            this.DownloadedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadedList.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadedList.ForeColor = System.Drawing.Color.Gold;
            this.DownloadedList.Location = new System.Drawing.Point(3, 3);
            this.DownloadedList.Name = "DownloadedList";
            this.DownloadedList.Size = new System.Drawing.Size(518, 382);
            this.DownloadedList.TabIndex = 1;
            this.DownloadedList.Text = "";
            // 
            // BuildName
            // 
            this.BuildName.BackColor = System.Drawing.Color.Black;
            this.BuildName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildName.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildName.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildName.ForeColor = System.Drawing.Color.PaleGreen;
            this.BuildName.Location = new System.Drawing.Point(3, 20);
            this.BuildName.Name = "BuildName";
            this.BuildName.ReadOnly = true;
            this.BuildName.Size = new System.Drawing.Size(183, 18);
            this.BuildName.TabIndex = 2;
            this.BuildName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameVersion
            // 
            this.GameVersion.BackColor = System.Drawing.Color.Black;
            this.GameVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameVersion.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersion.ForeColor = System.Drawing.Color.PaleGreen;
            this.GameVersion.Location = new System.Drawing.Point(3, 20);
            this.GameVersion.Name = "GameVersion";
            this.GameVersion.ReadOnly = true;
            this.GameVersion.Size = new System.Drawing.Size(183, 18);
            this.GameVersion.TabIndex = 3;
            this.GameVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Build:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game Version:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownloadList
            // 
            this.DownloadList.BackColor = System.Drawing.Color.Black;
            this.DownloadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadList.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadList.ForeColor = System.Drawing.Color.Gold;
            this.DownloadList.FormattingEnabled = true;
            this.DownloadList.Location = new System.Drawing.Point(3, 3);
            this.DownloadList.Name = "DownloadList";
            this.DownloadList.Size = new System.Drawing.Size(256, 382);
            this.DownloadList.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DownloadButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LatestDownload, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.DownloadButton.FlatAppearance.BorderSize = 2;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.DownloadButton.Location = new System.Drawing.Point(597, 6);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(191, 42);
            this.DownloadButton.TabIndex = 3;
            this.DownloadButton.Text = "Download Files";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BuildName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(191, 42);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.GameVersion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 6);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(191, 42);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 57);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DownloadList);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DownloadedList);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(794, 390);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 8;
            // 
            // Sainan_Scripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sainan_Scripts";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Sainan_Scripts";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LatestDownload;
        private System.Windows.Forms.RichTextBox DownloadedList;
        private System.Windows.Forms.TextBox BuildName;
        private System.Windows.Forms.TextBox GameVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox DownloadList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}