﻿namespace Lab3
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ipnum = new System.Windows.Forms.TextBox();
            this.portnum = new System.Windows.Forms.TextBox();
            this.Mess = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remote Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Message";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ipnum
            // 
            this.ipnum.Location = new System.Drawing.Point(74, 73);
            this.ipnum.Name = "ipnum";
            this.ipnum.Size = new System.Drawing.Size(169, 22);
            this.ipnum.TabIndex = 1;
            // 
            // portnum
            // 
            this.portnum.Location = new System.Drawing.Point(363, 73);
            this.portnum.Name = "portnum";
            this.portnum.Size = new System.Drawing.Size(169, 22);
            this.portnum.TabIndex = 1;
            // 
            // Mess
            // 
            this.Mess.Location = new System.Drawing.Point(74, 181);
            this.Mess.Multiline = true;
            this.Mess.Name = "Mess";
            this.Mess.Size = new System.Drawing.Size(458, 122);
            this.Mess.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mess);
            this.Controls.Add(this.portnum);
            this.Controls.Add(this.ipnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipnum;
        private System.Windows.Forms.TextBox portnum;
        private System.Windows.Forms.TextBox Mess;
        private System.Windows.Forms.Button button1;
    }
}