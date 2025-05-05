using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        

        private void read_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng chọn file
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);                
                string content = sr.ReadToEnd();
                In_Out.Text = content;
                fs.Close();
                MessageBox.Show("Đọc file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn đã hủy chọn file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            

        }
        private void write_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng chọn file
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                string content = In_Out.Text.ToUpper();
                sw.WriteLine(content);
                sw.Flush();
                fs.Close();
                MessageBox.Show("Ghi file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Bạn đã hủy chọn file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
