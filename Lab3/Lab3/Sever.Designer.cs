﻿namespace Lab3
{
    partial class Sever
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
            this.Mess = new System.Windows.Forms.TextBox();
            this.portnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Listen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mess
            // 
            this.Mess.Location = new System.Drawing.Point(70, 179);
            this.Mess.Multiline = true;
            this.Mess.Name = "Mess";
            this.Mess.Size = new System.Drawing.Size(169, 154);
            this.Mess.TabIndex = 6;
            // 
            // portnum
            // 
            this.portnum.Location = new System.Drawing.Point(70, 71);
            this.portnum.Name = "portnum";
            this.portnum.Size = new System.Drawing.Size(169, 22);
            this.portnum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Remote Host";
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mess);
            this.Controls.Add(this.portnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Sever";
            this.Text = "Sever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Mess;
        private System.Windows.Forms.TextBox portnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}