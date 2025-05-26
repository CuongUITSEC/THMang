using System.Windows.Forms;

namespace Lab4
{
    partial class Exercise3Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declare controls as fields
        private TextBox txtUrl;
        private TextBox txtFile;
        private Button btnDownload;
        private TextBox txtContent;

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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(400, 22);
            this.txtUrl.TabIndex = 0;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(12, 40);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(400, 22);
            this.txtFile.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(420, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 50);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 70);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(508, 350);
            this.txtContent.TabIndex = 3;
            // 
            // Exercise3Form
            // 
            this.ClientSize = new System.Drawing.Size(532, 430);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtContent);
            this.Name = "Exercise3Form";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
