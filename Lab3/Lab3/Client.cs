using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string ip = ipnum.Text.Trim();
                int port = int.Parse(portnum.Text.Trim());
                string message = Mess.Text;

                using (TcpClient client = new TcpClient(ip, port))
                using (NetworkStream stream = client.GetStream())
                {
                    // Gửi thông điệp
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    //// Nhận phản hồi từ Server
                    //byte[] response = new byte[1024];
                    //int bytesRead = stream.Read(response, 0, response.Length);
                    //string serverResponse = Encoding.ASCII.GetString(response, 0, bytesRead);

                    // Hiển thị phản hồi dưới dạng MessageBox
                    //MessageBox.Show(serverResponse, "Server Response",
                    //                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Port phải là một số nguyên.", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SocketException)
            {
                MessageBox.Show("Không kết nối được tới Server. Kiểm tra lại IP/Port và Server đã chạy chưa?",
                                "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
