using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Lab4
{
    public partial class Exercise1Form : Form
    {
        public Exercise1Form()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            WebRequest request = WebRequest.Create(szUrl);
            using (WebResponse response = request.GetResponse())
         
            using (Stream dataStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream))
            {
                string responseFromServer = reader.ReadToEnd();
                return responseFromServer;
            }
        }

        // Ví dụ: Gọi hàm này khi nhấn nút trên form
        private void btnGetHtml_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim(); // Lấy URL từ TextBox

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Vui lòng nhập URL.");
                return;
            }

            try
            {
                string html = getHTML(url);
                txtHtml.Text = html; // Hiển thị nội dung HTML trong txtHtml
                File.WriteAllText("output.html", html);
                MessageBox.Show("Đã lưu nội dung HTML vào file output.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        
    }
}
