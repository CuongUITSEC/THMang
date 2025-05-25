namespace Lab4
{
    partial class Exercise1Form
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGetHtml = new System.Windows.Forms.Button();
            this.txtHtml = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(60, 15);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(400, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://localhost/index.html";
            // 
            // btnGetHtml
            // 
            this.btnGetHtml.Location = new System.Drawing.Point(480, 12);
            this.btnGetHtml.Name = "btnGetHtml";
            this.btnGetHtml.Size = new System.Drawing.Size(100, 28);
            this.btnGetHtml.TabIndex = 1;
            this.btnGetHtml.Text = "Get HTML";
            this.btnGetHtml.UseVisualStyleBackColor = true;
            this.btnGetHtml.Click += new System.EventHandler(this.btnGetHtml_Click);
            // 
            // txtHtml
            // 
            this.txtHtml.Location = new System.Drawing.Point(15, 50);
            this.txtHtml.Multiline = true;
            this.txtHtml.Name = "txtHtml";
            this.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHtml.Size = new System.Drawing.Size(565, 300);
            this.txtHtml.TabIndex = 2;
            this.txtHtml.WordWrap = false;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 16);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "URL";
            // 
            // Exercise1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtHtml);
            this.Controls.Add(this.btnGetHtml);
            this.Controls.Add(this.txtUrl);
            this.Name = "Exercise1Form";
            this.Text = "Exercise 1 - Get HTML";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGetHtml;
        private System.Windows.Forms.TextBox txtHtml;
        private System.Windows.Forms.Label lblUrl;
    }
}