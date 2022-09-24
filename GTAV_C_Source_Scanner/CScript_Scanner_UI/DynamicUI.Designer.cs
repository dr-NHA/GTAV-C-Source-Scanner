namespace NHA_CScriptScannerUI
{
    partial class DynamicUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicUI));
            this.PageOptions = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageOptions
            // 
            this.PageOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PageOptions.Controls.Add(this.HomeButton);
            this.PageOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageOptions.Location = new System.Drawing.Point(0, 0);
            this.PageOptions.Name = "PageOptions";
            this.PageOptions.Size = new System.Drawing.Size(800, 25);
            this.PageOptions.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Black;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(109, 23);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Back To Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // DynamicUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PageOptions);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DynamicUI";
            this.Text = "DynamicUI";
            this.PageOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PageOptions;
        private System.Windows.Forms.Button HomeButton;
    }
}