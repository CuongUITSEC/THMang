namespace Lab4
{
    partial class Menu
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

        private System.Windows.Forms.Button btnExercise1;
        private System.Windows.Forms.Button btnExercise2;
        private System.Windows.Forms.Button btnExercise3;
        private System.Windows.Forms.Button btnExercise4;

        private void InitializeComponent()
        {
            this.btnExercise1 = new System.Windows.Forms.Button();
            this.btnExercise2 = new System.Windows.Forms.Button();
            this.btnExercise3 = new System.Windows.Forms.Button();
            this.btnExercise4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercise1
            // 
            this.btnExercise1.Location = new System.Drawing.Point(50, 30);
            this.btnExercise1.Name = "btnExercise1";
            this.btnExercise1.Size = new System.Drawing.Size(200, 40);
            this.btnExercise1.TabIndex = 0;
            this.btnExercise1.Text = "Exercise 1";
            this.btnExercise1.UseVisualStyleBackColor = true;
            this.btnExercise1.Click += new System.EventHandler(this.btnExercise1_Click);
            // 
            // btnExercise2
            // 
            this.btnExercise2.Location = new System.Drawing.Point(50, 80);
            this.btnExercise2.Name = "btnExercise2";
            this.btnExercise2.Size = new System.Drawing.Size(200, 40);
            this.btnExercise2.TabIndex = 1;
            this.btnExercise2.Text = "Exercise 2";
            this.btnExercise2.UseVisualStyleBackColor = true;
            this.btnExercise2.Click += new System.EventHandler(this.btnExercise2_Click);
            // 
            // btnExercise3
            // 
            this.btnExercise3.Location = new System.Drawing.Point(50, 130);
            this.btnExercise3.Name = "btnExercise3";
            this.btnExercise3.Size = new System.Drawing.Size(200, 40);
            this.btnExercise3.TabIndex = 2;
            this.btnExercise3.Text = "Exercise 3";
            this.btnExercise3.UseVisualStyleBackColor = true;
            this.btnExercise3.Click += new System.EventHandler(this.btnExercise3_Click);
            // 
            // btnExercise4
            // 
            this.btnExercise4.Location = new System.Drawing.Point(50, 180);
            this.btnExercise4.Name = "btnExercise4";
            this.btnExercise4.Size = new System.Drawing.Size(200, 40);
            this.btnExercise4.TabIndex = 3;
            this.btnExercise4.Text = "Exercise 4";
            this.btnExercise4.UseVisualStyleBackColor = true;
            this.btnExercise4.Click += new System.EventHandler(this.btnExercise4_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.btnExercise1);
            this.Controls.Add(this.btnExercise2);
            this.Controls.Add(this.btnExercise3);
            this.Controls.Add(this.btnExercise4);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
        }
    }
}