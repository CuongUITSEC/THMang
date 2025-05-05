using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Sever : Form
    {
        TcpListener server;
        Thread serverThread;
        private int serverPort;  // lưu port từ textbox

        public Sever()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đọc port từ TextBox trước khi khởi động thread
            if (!int.TryParse(portnum.Text.Trim(), out serverPort))
            {
                MessageBox.Show("Port không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();
            Log("Server started on port " + serverPort);
        }

        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, serverPort);
                server.Start();

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    // Lấy IP của client
                    IPEndPoint remoteEP = (IPEndPoint)client.Client.RemoteEndPoint;
                    string clientIP = remoteEP.Address.ToString();
                    //UpdateIp(clientIP);

                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string received = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    UpdateMessage(received);
                    Log($"Received from {clientIP}: {received}");

                    // Gửi phản hồi
                    //string response = "Server received: " + received;
                    //byte[] responseBytes = Encoding.ASCII.GetBytes(response);
                    //stream.Write(responseBytes, 0, responseBytes.Length);

                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Log("Error in server: " + ex.Message);
            }
            finally
            {
                server?.Stop();
            }
        }

        private void Log(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(Log), message);
            }
            else
            {
                MessageBox.Show(message, "Server Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void UpdateIp(string ip)
        //{
        //    if (portnum.InvokeRequired)
        //        portnum.Invoke(new Action<string>(UpdateIp), ip);
        //    else
        //        portnum.Text = ip;
        //}

        private void UpdateMessage(string message)
        {
            if (Mess.InvokeRequired)
                Mess.Invoke(new Action<string>(UpdateMessage), message);
            else
                Mess.AppendText(message + Environment.NewLine);

        }
    }
}
