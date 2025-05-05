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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng chọn file
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                URL.Text = ofd.FileName;
                Name_File.Text = Path.GetFileName(ofd.FileName);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                In_Text.Text = content;

                int CharCount = content.Length;
                NumChar.Text=CharCount.ToString();

                // Đếm dòng
                int lineCount = content.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).Length;
                NumLine.Text = lineCount.ToString();

                // Đếm từ
                string[] words = content.Split(new char[] { ' ', '\r', '\n', '.', ',', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                NumWord.Text = words.Length.ToString();
                fs.Close();
                MessageBox.Show("Đọc file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn đã hủy chọn file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
