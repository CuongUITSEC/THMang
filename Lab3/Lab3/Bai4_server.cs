using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai4_server : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        private bool isListening = false;

        private List<TcpClient> clients = new List<TcpClient>();
        private object clientLock = new object();

        public Bai4_server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                StartListening();
            }
            else
            {
                StopListening();
            }
        }

        private void StartListening()
        {
            try
            {
                isListening = true;
                btnListen.Text = "Stop Listening";

                tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                listenThread = new Thread(ListenForClients);
                listenThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListenForClients()
        {
            tcpListener.Start();
            AddMessage("Server running on 127.0.0.1:8080");

            try
            {
                while (isListening)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    AddMessage("New client connected from: " + client.Client.RemoteEndPoint.ToString());

                    lock (clientLock)
                    {
                        clients.Add(client);
                    }

                    Thread clientThread = new Thread(HandleClientComm);
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                if (isListening)
                    AddMessage("Error: " + ex.Message);
            }
        }

        private void HandleClientComm(object clientObj)
        {
            TcpClient tcpClient = (TcpClient)clientObj;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            try
            {
                while (isListening && (bytesRead = clientStream.Read(message, 0, 4096)) != 0)
                {
                    string data = Encoding.UTF8.GetString(message, 0, bytesRead);
                    string clientEndpoint = tcpClient.Client.RemoteEndPoint.ToString();
                    string messageWithIP = $"[{clientEndpoint}] {data}";

                    AddMessage(messageWithIP);
                    BroadcastMessage(data, tcpClient); // giữ nguyên nội dung gửi cho các client khác

                }
            }
            catch
            {
                // Ignore error when client disconnects
            }
            finally
            {
                lock (clientLock)
                {
                    clients.Remove(tcpClient);
                }
                tcpClient.Close();
            }
        }

        private void BroadcastMessage(string message, TcpClient excludeClient)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            lock (clientLock)
            {
                foreach (var client in clients.ToArray())
                {
                    try
                    {
                        if (client != excludeClient)
                        {
                            NetworkStream stream = client.GetStream();
                            stream.Write(buffer, 0, buffer.Length);
                        }
                    }
                    catch
                    {
                        clients.Remove(client); // Remove disconnected clients
                    }
                }
            }
        }

        private void StopListening()
        {
            isListening = false;
            btnListen.Text = "Listen";

            lock (clientLock)
            {
                foreach (var client in clients)
                {
                    try { client.Close(); } catch { }
                }
                clients.Clear();
            }

            tcpListener?.Stop();
        }

        private void AddMessage(string message)
        {
            if (listViewMessages.InvokeRequired)
            {
                listViewMessages.Invoke((MethodInvoker)delegate
                {
                    listViewMessages.Items.Add(message);
                });
            }
            else
            {
                listViewMessages.Items.Add(message);
            }
        }

        private void Bai4_server_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopListening();
        }
    }
}
