namespace NHA_CScriptScannerUI
{
    partial class Uploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uploader));
            this.GitUserToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UploadGlobalOffsets = new System.Windows.Forms.Button();
            this.UpdateInfo = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.ProjectList = new System.Windows.Forms.ListBox();
            this.GithubTokenPanel = new System.Windows.Forms.Panel();
            this.CreatePAT = new System.Windows.Forms.LinkLabel();
            this.SelectProject = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UploadPanel = new System.Windows.Forms.Panel();
            this.RepoX = new System.Windows.Forms.TextBox();
            this.UploadCleanedScripts = new System.Windows.Forms.Button();
            this.UploadNatives = new System.Windows.Forms.Button();
            this.UploadScriptsStatus = new System.Windows.Forms.RichTextBox();
            this.UI = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.GithubTokenPanel.SuspendLayout();
            this.UploadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GitUserToken
            // 
            this.GitUserToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.GitUserToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GitUserToken.Dock = System.Windows.Forms.DockStyle.Top;
            this.GitUserToken.ForeColor = System.Drawing.Color.Chartreuse;
            this.GitUserToken.Location = new System.Drawing.Point(3, 16);
            this.GitUserToken.Name = "GitUserToken";
            this.GitUserToken.Size = new System.Drawing.Size(182, 20);
            this.GitUserToken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Github User Token";
            // 
            // UploadGlobalOffsets
            // 
            this.UploadGlobalOffsets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadGlobalOffsets.Location = new System.Drawing.Point(3, 59);
            this.UploadGlobalOffsets.Name = "UploadGlobalOffsets";
            this.UploadGlobalOffsets.Size = new System.Drawing.Size(133, 23);
            this.UploadGlobalOffsets.TabIndex = 2;
            this.UploadGlobalOffsets.Text = "Upload Global Offsets";
            this.UploadGlobalOffsets.UseVisualStyleBackColor = true;
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.UpdateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.UpdateInfo.Location = new System.Drawing.Point(3, 33);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.ReadOnly = true;
            this.UpdateInfo.Size = new System.Drawing.Size(266, 20);
            this.UpdateInfo.TabIndex = 3;
            this.UpdateInfo.Text = "*Update Info";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AccountPanel);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.UploadPanel);
            this.splitContainer1.Size = new System.Drawing.Size(794, 444);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 4;
            // 
            // AccountPanel
            // 
            this.AccountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountPanel.Controls.Add(this.ProjectList);
            this.AccountPanel.Controls.Add(this.GithubTokenPanel);
            this.AccountPanel.Controls.Add(this.SelectProject);
            this.AccountPanel.Controls.Add(this.LoginButton);
            this.AccountPanel.Controls.Add(this.GitUserToken);
            this.AccountPanel.Controls.Add(this.label1);
            this.AccountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountPanel.Location = new System.Drawing.Point(3, 3);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Padding = new System.Windows.Forms.Padding(3);
            this.AccountPanel.Size = new System.Drawing.Size(190, 438);
            this.AccountPanel.TabIndex = 0;
            // 
            // ProjectList
            // 
            this.ProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ProjectList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectList.ForeColor = System.Drawing.Color.Chartreuse;
            this.ProjectList.FormattingEnabled = true;
            this.ProjectList.Location = new System.Drawing.Point(3, 79);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(182, 331);
            this.ProjectList.TabIndex = 4;
            // 
            // GithubTokenPanel
            // 
            this.GithubTokenPanel.Controls.Add(this.CreatePAT);
            this.GithubTokenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GithubTokenPanel.Location = new System.Drawing.Point(3, 59);
            this.GithubTokenPanel.Name = "GithubTokenPanel";
            this.GithubTokenPanel.Padding = new System.Windows.Forms.Padding(3);
            this.GithubTokenPanel.Size = new System.Drawing.Size(182, 20);
            this.GithubTokenPanel.TabIndex = 4;
            // 
            // CreatePAT
            // 
            this.CreatePAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreatePAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatePAT.Location = new System.Drawing.Point(3, 3);
            this.CreatePAT.Name = "CreatePAT";
            this.CreatePAT.Size = new System.Drawing.Size(176, 14);
            this.CreatePAT.TabIndex = 6;
            this.CreatePAT.TabStop = true;
            this.CreatePAT.Text = "https://github.com/settings/tokens";
            this.CreatePAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectProject
            // 
            this.SelectProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectProject.Location = new System.Drawing.Point(3, 410);
            this.SelectProject.Name = "SelectProject";
            this.SelectProject.Size = new System.Drawing.Size(182, 23);
            this.SelectProject.TabIndex = 4;
            this.SelectProject.Text = "Select Project";
            this.SelectProject.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(3, 36);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(182, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // UploadPanel
            // 
            this.UploadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UploadPanel.Controls.Add(this.UploadScriptsStatus);
            this.UploadPanel.Controls.Add(this.RepoX);
            this.UploadPanel.Controls.Add(this.UploadCleanedScripts);
            this.UploadPanel.Controls.Add(this.UploadNatives);
            this.UploadPanel.Controls.Add(this.UpdateInfo);
            this.UploadPanel.Controls.Add(this.UploadGlobalOffsets);
            this.UploadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UploadPanel.Location = new System.Drawing.Point(0, 0);
            this.UploadPanel.Name = "UploadPanel";
            this.UploadPanel.Padding = new System.Windows.Forms.Padding(3);
            this.UploadPanel.Size = new System.Drawing.Size(594, 444);
            this.UploadPanel.TabIndex = 1;
            // 
            // RepoX
            // 
            this.RepoX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.RepoX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepoX.ForeColor = System.Drawing.Color.Chartreuse;
            this.RepoX.Location = new System.Drawing.Point(3, 3);
            this.RepoX.Name = "RepoX";
            this.RepoX.ReadOnly = true;
            this.RepoX.Size = new System.Drawing.Size(266, 20);
            this.RepoX.TabIndex = 6;
            // 
            // UploadCleanedScripts
            // 
            this.UploadCleanedScripts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadCleanedScripts.Location = new System.Drawing.Point(3, 117);
            this.UploadCleanedScripts.Name = "UploadCleanedScripts";
            this.UploadCleanedScripts.Size = new System.Drawing.Size(205, 23);
            this.UploadCleanedScripts.TabIndex = 5;
            this.UploadCleanedScripts.Text = "Upload Cleaned Decompiled Scripts";
            this.UploadCleanedScripts.UseVisualStyleBackColor = true;
            // 
            // UploadNatives
            // 
            this.UploadNatives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadNatives.Location = new System.Drawing.Point(3, 88);
            this.UploadNatives.Name = "UploadNatives";
            this.UploadNatives.Size = new System.Drawing.Size(133, 23);
            this.UploadNatives.TabIndex = 4;
            this.UploadNatives.Text = "Upload Natives";
            this.UploadNatives.UseVisualStyleBackColor = true;
            // 
            // UploadScriptsStatus
            // 
            this.UploadScriptsStatus.BackColor = System.Drawing.Color.Black;
            this.UploadScriptsStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UploadScriptsStatus.ForeColor = System.Drawing.Color.Chartreuse;
            this.UploadScriptsStatus.Location = new System.Drawing.Point(6, 172);
            this.UploadScriptsStatus.Name = "UploadScriptsStatus";
            this.UploadScriptsStatus.Size = new System.Drawing.Size(304, 211);
            this.UploadScriptsStatus.TabIndex = 8;
            this.UploadScriptsStatus.Text = "";
            this.UploadScriptsStatus.WordWrap = false;
            // 
            // UI
            // 
            this.UI.Enabled = true;
            // 
            // Uploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uploader";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Uploader";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.GithubTokenPanel.ResumeLayout(false);
            this.UploadPanel.ResumeLayout(false);
            this.UploadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox GitUserToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UploadGlobalOffsets;
        private System.Windows.Forms.TextBox UpdateInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Panel UploadPanel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ListBox ProjectList;
        private System.Windows.Forms.Panel GithubTokenPanel;
        private System.Windows.Forms.Button SelectProject;
        private System.Windows.Forms.Button UploadCleanedScripts;
        private System.Windows.Forms.Button UploadNatives;
        private System.Windows.Forms.LinkLabel CreatePAT;
        private System.Windows.Forms.TextBox RepoX;
        private System.Windows.Forms.RichTextBox UploadScriptsStatus;
        private System.Windows.Forms.Timer UI;
    }
}