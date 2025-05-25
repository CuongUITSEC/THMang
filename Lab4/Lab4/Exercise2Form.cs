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
    public partial class Exercise2Form : Form
    {
        public Exercise2Form()
        {
            InitializeComponent();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            string url = textBoxUrl.Text.Trim(); // Lấy URL từ textbox mới
            string postData = textBoxInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Vui lòng nhập URL.");
                return;
            }

            if (string.IsNullOrWhiteSpace(postData))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu POST (dạng key1=value1&key2=value2)");
                return;
            }

            try
            {
                // Bước 2: Mã hóa nội dung thành byte array
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Bước 3: Tạo yêu cầu HTTP và cấu hình
                WebRequest request = WebRequest.Create(url);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                // Bước 4: Gửi dữ liệu lên server
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                // Bước 5: Nhận và hiển thị phản hồi
                using (WebResponse response = request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseFromServer = reader.ReadToEnd();
                    textBoxResult.Text = responseFromServer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
