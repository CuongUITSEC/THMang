using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai4_client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool isConnected = false;

        public Bai4_client()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Messages", 540);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        //private void btnSend_Click(object sender, EventArgs e)
        //{
        //    if (!isConnected)
        //    {
        //        ConnectToServer();
        //    }

        //    if (isConnected && !string.IsNullOrWhiteSpace(txtMessage.Text))
        //    {
        //        string name = txtName.Text.Trim();
        //        if (string.IsNullOrWhiteSpace(name))
        //        {
        //            MessageBox.Show("Please enter your name.");
        //            return;
        //        }

        //        string fullMessage = $"{name}: {txtMessage.Text.Trim()}";
        //        SendMessage(fullMessage);
        //        txtMessage.Clear();
        //    }
        //}
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                ConnectToServer();
            }

            if (isConnected && !string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                string name = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter your name.");
                    return;
                }

                string fullMessage = $"{name}: {txtMessage.Text.Trim()}";

                SendMessage(fullMessage);

                AddMessage(fullMessage);

                txtMessage.Clear();
            }
        }


        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);
                stream = client.GetStream();

                isConnected = true;

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();

                AddMessage("✅ Connected to server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to server: " + ex.Message);
            }
        }

        private void SendMessage(string message)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
            catch
            {
                MessageBox.Show("Connection lost.");
                Disconnect();
            }
        }

        private void ReceiveMessages()
        {
            try
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AddMessage(message);
                }
            }
            catch
            {
                if (isConnected)
                    AddMessage("❌ Connection lost.");
            }
            finally
            {
                Disconnect();
            }
        }

        private void AddMessage(string message)
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke((MethodInvoker)(() =>
                {
                    listView1.Items.Add(new ListViewItem(message));
                    listView1.EnsureVisible(listView1.Items.Count - 1);
                }));
            }
            else
            {
                listView1.Items.Add(new ListViewItem(message));
                listView1.EnsureVisible(listView1.Items.Count - 1);
            }
        }

        private void Disconnect()
        {
            isConnected = false;

            stream?.Close();
            client?.Close();

            AddMessage("❎ Disconnected.");
        }

        private void Bai4_client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
    }
}
