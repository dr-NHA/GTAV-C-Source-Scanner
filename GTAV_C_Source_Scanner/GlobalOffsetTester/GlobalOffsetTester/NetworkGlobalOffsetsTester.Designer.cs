namespace GlobalOffsetTester
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HosterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HosterRepo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HosterBranch = new System.Windows.Forms.TextBox();
            this.SetHosterInfo = new System.Windows.Forms.Button();
            this.HosterInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.XGlobalOffsets = new System.Windows.Forms.Panel();
            this.Globals = new System.Windows.Forms.RichTextBox();
            this.SetGameVersion = new System.Windows.Forms.Button();
            this.GameVersions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuildName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GameVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HosterInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.XGlobalOffsets.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // HosterName
            // 
            this.HosterName.BackColor = System.Drawing.Color.Black;
            this.HosterName.Dock = System.Windows.Forms.DockStyle.Top;
            this.HosterName.ForeColor = System.Drawing.Color.PaleGreen;
            this.HosterName.Location = new System.Drawing.Point(0, 11);
            this.HosterName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HosterName.Name = "HosterName";
            this.HosterName.Size = new System.Drawing.Size(95, 18);
            this.HosterName.TabIndex = 0;
            this.HosterName.Text = "dr-NHA";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 11);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoster Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 11);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hoster Repo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HosterRepo
            // 
            this.HosterRepo.BackColor = System.Drawing.Color.Black;
            this.HosterRepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.HosterRepo.ForeColor = System.Drawing.Color.PaleGreen;
            this.HosterRepo.Location = new System.Drawing.Point(0, 11);
            this.HosterRepo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HosterRepo.Name = "HosterRepo";
            this.HosterRepo.Size = new System.Drawing.Size(95, 18);
            this.HosterRepo.TabIndex = 2;
            this.HosterRepo.Text = "GtaV_2";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 11);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hoster Branch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HosterBranch
            // 
            this.HosterBranch.BackColor = System.Drawing.Color.Black;
            this.HosterBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.HosterBranch.ForeColor = System.Drawing.Color.PaleGreen;
            this.HosterBranch.Location = new System.Drawing.Point(0, 11);
            this.HosterBranch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HosterBranch.Name = "HosterBranch";
            this.HosterBranch.Size = new System.Drawing.Size(125, 18);
            this.HosterBranch.TabIndex = 4;
            this.HosterBranch.Text = "main";
            // 
            // SetHosterInfo
            // 
            this.SetHosterInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetHosterInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetHosterInfo.ForeColor = System.Drawing.Color.PaleGreen;
            this.SetHosterInfo.Location = new System.Drawing.Point(349, 3);
            this.SetHosterInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SetHosterInfo.Name = "SetHosterInfo";
            this.SetHosterInfo.Size = new System.Drawing.Size(71, 33);
            this.SetHosterInfo.TabIndex = 6;
            this.SetHosterInfo.Text = "Set Hoster";
            this.SetHosterInfo.UseVisualStyleBackColor = true;
            // 
            // HosterInfo
            // 
            this.HosterInfo.ColumnCount = 4;
            this.HosterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HosterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HosterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.93146F));
            this.HosterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.2243F));
            this.HosterInfo.Controls.Add(this.SetHosterInfo, 3, 0);
            this.HosterInfo.Controls.Add(this.panel3, 1, 0);
            this.HosterInfo.Controls.Add(this.panel2, 0, 0);
            this.HosterInfo.Controls.Add(this.panel4, 2, 0);
            this.HosterInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.HosterInfo.Location = new System.Drawing.Point(0, 0);
            this.HosterInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HosterInfo.Name = "HosterInfo";
            this.HosterInfo.RowCount = 1;
            this.HosterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HosterInfo.Size = new System.Drawing.Size(424, 39);
            this.HosterInfo.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.HosterRepo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(109, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 33);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.HosterName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.HosterBranch);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(214, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 33);
            this.panel4.TabIndex = 3;
            // 
            // XGlobalOffsets
            // 
            this.XGlobalOffsets.Controls.Add(this.Globals);
            this.XGlobalOffsets.Controls.Add(this.SetGameVersion);
            this.XGlobalOffsets.Controls.Add(this.tableLayoutPanel1);
            this.XGlobalOffsets.Controls.Add(this.GameVersions);
            this.XGlobalOffsets.Controls.Add(this.label4);
            this.XGlobalOffsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XGlobalOffsets.Location = new System.Drawing.Point(0, 39);
            this.XGlobalOffsets.Name = "XGlobalOffsets";
            this.XGlobalOffsets.Size = new System.Drawing.Size(424, 202);
            this.XGlobalOffsets.TabIndex = 11;
            // 
            // Globals
            // 
            this.Globals.BackColor = System.Drawing.Color.Black;
            this.Globals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Globals.ForeColor = System.Drawing.Color.PaleGreen;
            this.Globals.Location = new System.Drawing.Point(0, 122);
            this.Globals.Name = "Globals";
            this.Globals.Size = new System.Drawing.Size(424, 80);
            this.Globals.TabIndex = 13;
            this.Globals.Text = "";
            this.Globals.WordWrap = false;
            // 
            // SetGameVersion
            // 
            this.SetGameVersion.BackColor = System.Drawing.Color.Black;
            this.SetGameVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetGameVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetGameVersion.ForeColor = System.Drawing.Color.PaleGreen;
            this.SetGameVersion.Location = new System.Drawing.Point(0, 100);
            this.SetGameVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SetGameVersion.Name = "SetGameVersion";
            this.SetGameVersion.Size = new System.Drawing.Size(424, 22);
            this.SetGameVersion.TabIndex = 12;
            this.SetGameVersion.Text = "Get Version Global Offsets";
            this.SetGameVersion.UseVisualStyleBackColor = false;
            // 
            // GameVersions
            // 
            this.GameVersions.BackColor = System.Drawing.Color.Black;
            this.GameVersions.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameVersions.ForeColor = System.Drawing.Color.PaleGreen;
            this.GameVersions.FormattingEnabled = true;
            this.GameVersions.ItemHeight = 11;
            this.GameVersions.Location = new System.Drawing.Point(0, 11);
            this.GameVersions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameVersions.Name = "GameVersions";
            this.GameVersions.ScrollAlwaysVisible = true;
            this.GameVersions.Size = new System.Drawing.Size(424, 48);
            this.GameVersions.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 11);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hoster Compatible Versions";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 41);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BuildName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 35);
            this.panel1.TabIndex = 3;
            // 
            // BuildName
            // 
            this.BuildName.BackColor = System.Drawing.Color.Black;
            this.BuildName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildName.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildName.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildName.ForeColor = System.Drawing.Color.PaleGreen;
            this.BuildName.Location = new System.Drawing.Point(0, 15);
            this.BuildName.Name = "BuildName";
            this.BuildName.Size = new System.Drawing.Size(206, 18);
            this.BuildName.TabIndex = 2;
            this.BuildName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleGreen;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Build:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GameVersion);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(215, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 35);
            this.panel5.TabIndex = 4;
            // 
            // GameVersion
            // 
            this.GameVersion.BackColor = System.Drawing.Color.Black;
            this.GameVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameVersion.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersion.ForeColor = System.Drawing.Color.PaleGreen;
            this.GameVersion.Location = new System.Drawing.Point(0, 15);
            this.GameVersion.Name = "GameVersion";
            this.GameVersion.Size = new System.Drawing.Size(206, 18);
            this.GameVersion.TabIndex = 3;
            this.GameVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleGreen;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game Version:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 241);
            this.Controls.Add(this.XGlobalOffsets);
            this.Controls.Add(this.HosterInfo);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(440, 280);
            this.Name = "MainForm";
            this.Text = "NHA\'s Network Global Tester";
            this.HosterInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.XGlobalOffsets.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HosterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HosterRepo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HosterBranch;
        private System.Windows.Forms.Button SetHosterInfo;
        private System.Windows.Forms.TableLayoutPanel HosterInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel XGlobalOffsets;
        private System.Windows.Forms.Button SetGameVersion;
        private System.Windows.Forms.ListBox GameVersions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Globals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox GameVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BuildName;
        private System.Windows.Forms.Label label5;
    }
}

