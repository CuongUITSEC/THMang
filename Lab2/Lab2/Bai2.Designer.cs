namespace Lab2
{
    partial class Bai2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_File = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.NumLine = new System.Windows.Forms.TextBox();
            this.NumWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumChar = new System.Windows.Forms.TextBox();
            this.In_Text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(477, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đọc file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên file";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số dòng";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số từ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name_File
            // 
            this.Name_File.Location = new System.Drawing.Point(136, 131);
            this.Name_File.Name = "Name_File";
            this.Name_File.Size = new System.Drawing.Size(376, 22);
            this.Name_File.TabIndex = 2;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(136, 177);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(376, 22);
            this.URL.TabIndex = 2;
            // 
            // NumLine
            // 
            this.NumLine.Location = new System.Drawing.Point(136, 222);
            this.NumLine.Name = "NumLine";
            this.NumLine.Size = new System.Drawing.Size(376, 22);
            this.NumLine.TabIndex = 2;
            // 
            // NumWord
            // 
            this.NumWord.Location = new System.Drawing.Point(136, 320);
            this.NumWord.Name = "NumWord";
            this.NumWord.Size = new System.Drawing.Size(376, 22);
            this.NumWord.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số ký tự";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumChar
            // 
            this.NumChar.Location = new System.Drawing.Point(136, 274);
            this.NumChar.Name = "NumChar";
            this.NumChar.Size = new System.Drawing.Size(376, 22);
            this.NumChar.TabIndex = 2;
            // 
            // In_Text
            // 
            this.In_Text.Location = new System.Drawing.Point(547, 57);
            this.In_Text.Multiline = true;
            this.In_Text.Name = "In_Text";
            this.In_Text.Size = new System.Drawing.Size(338, 293);
            this.In_Text.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.In_Text);
            this.Controls.Add(this.NumChar);
            this.Controls.Add(this.NumWord);
            this.Controls.Add(this.NumLine);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Name_File);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Bai2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_File;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox NumLine;
        private System.Windows.Forms.TextBox NumWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumChar;
        private System.Windows.Forms.TextBox In_Text;
        private System.Windows.Forms.Button button2;
    }
}