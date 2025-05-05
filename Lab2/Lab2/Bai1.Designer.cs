namespace Lab2
{
    partial class Bai1
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
            this.read = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.In_Out = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(71, 47);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(120, 57);
            this.read.TabIndex = 0;
            this.read.Text = "Đọc file";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click_1);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(71, 158);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(120, 57);
            this.write.TabIndex = 0;
            this.write.Text = "Ghi file";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click_1);
            // 
            // In_Out
            // 
            this.In_Out.Location = new System.Drawing.Point(247, 47);
            this.In_Out.Multiline = true;
            this.In_Out.Name = "In_Out";
            this.In_Out.Size = new System.Drawing.Size(397, 235);
            this.In_Out.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(71, 264);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 57);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 361);
            this.Controls.Add(this.In_Out);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Name = "Bai1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.TextBox In_Out;
        private System.Windows.Forms.Button Exit;
    }
}