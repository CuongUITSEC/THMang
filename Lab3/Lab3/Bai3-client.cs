using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai3_client : Form
    {
        private TcpClient tcpClient = null;
        private NetworkStream clientStream = null;
        private bool isConnected = false;

        public Bai3_client()
        {
            InitializeComponent();
            btnSend.Enabled = false; // Vô hiệu hóa nút Send ban đầu
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    //khởi tạo
                    tcpClient = new TcpClient();
                    tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);

                    clientStream = tcpClient.GetStream();
                    isConnected = true;
                    btnSend.Enabled = true;
                    btnConnect.Text = "Disconnect";
                    MessageBox.Show("Connected to server!");
                }
                else
                {
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!isConnected || clientStream == null)
            {
                MessageBox.Show("Not connected to server!");
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
                    clientStream.Write(data, 0, data.Length);
                    txtMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
                Disconnect();
            }
        }

        private void Disconnect()
        {
            try
            {
                // Gửi tín hiệu quit trước khi đóng kết nối
                if (isConnected && clientStream != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes("Client quited\n");
                    try
                    {
                        clientStream.Write(data, 0, data.Length);
                    }
                    catch { } // Bỏ qua nếu không gửi được
                }

                // Đóng kết nối
                if (clientStream != null)
                {
                    clientStream.Close();
                    clientStream = null;
                }
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    tcpClient = null;
                }

                // Cập nhật trạng thái
                isConnected = false;
                btnSend.Enabled = false;
                btnConnect.Text = "Connect";
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu cần
                Debug.WriteLine("Disconnect error: " + ex.Message);
            }
        }

        private void Bai3_client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

    }
}