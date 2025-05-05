using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng chọn file
            {
                string[] lines =File.ReadAllLines(ofd.FileName);
                string resultText = "";
                foreach (string line in lines)
                {
                    string trimmed = line.Trim();
                    char[] ops = { '+', '-', '*', '/' };

                    foreach (char op in ops)
                    {
                        int idx = trimmed.IndexOf(op);
                        if (idx > 0)
                        {
                            string left = trimmed.Substring(0, idx).Trim();
                            string right = trimmed.Substring(idx + 1).Trim();

                            if (int.TryParse(left, out int a) && int.TryParse(right, out int b))
                            {
                                int result=0;
                                if (op == '+') result = a + b;
                                else if(op=='-') result = a-b;
                                else if(op=='*') result = b*a;
                                else if(op == '/')
                                {
                                    if (b != 0) result = a / b;
                                    else result = 0;
                                }


                                if (op == '/' && b == 0)
                                {
                                    resultText += $"{a} {op}{b} = Lỗi!\r\n";
                                }
                                else resultText += $"{a} {op}{b} = {result}\r\n";

                            }
                            break;
                        }
                        else MessageBox.Show("Vui lòng nhập đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                } 
                demo.Text= resultText;

                OpenFileDialog ofdw = new OpenFileDialog();
                if (ofdw.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng chọn file
                {
                    FileStream fs = new FileStream(ofdw.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(resultText);
                    sw.Flush();
                    fs.Close();
                    MessageBox.Show("Extend file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy chọn file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Bạn đã hủy chọn file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
