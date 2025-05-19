using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai3_server : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        private bool isListening = false;

        public Bai3_server()
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
                listenThread = new Thread(new ThreadStart(ListenForClients));
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
                    AddMessage("New client connected");

                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                if (isListening) // Only show error if we didn't stop intentionally
                    AddMessage("Error: " + ex.Message);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            try
            {
                while (isListening && (bytesRead = clientStream.Read(message, 0, 4096)) != 0)
                {
                    string data = Encoding.UTF8.GetString(message, 0, bytesRead);
                    AddMessage(data);
                }
            }
            catch
            {
                // Client disconnected
            }
            finally
            {
                clientStream.Close();
                tcpClient.Close();
            }
        }

        private void StopListening()
        {
            isListening = false;
            btnListen.Text = "Listen";

            if (tcpListener != null)
            {
                tcpListener.Stop();
            }
        }

        private void AddMessage(string message)
        {
            if (listViewMessages.InvokeRequired)
            {
                listViewMessages.Invoke((MethodInvoker)delegate {
                    listViewMessages.Items.Add(message);
                });
            }
            else
            {
                listViewMessages.Items.Add(message);
            }
        }

        private void Bai3_server_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopListening();
        }
    }
}