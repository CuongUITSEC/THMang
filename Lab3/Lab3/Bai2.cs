using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
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
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }



        void StartUnsafeThread()
        {
            byte[] recv = new byte[1024];
            int bytesReceived;

            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ippeServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ippeServer);
            listenerSocket.Listen(1);

            Socket clientSocket = listenerSocket.Accept();

            listViewCommand.Invoke(new Action(() =>
            {
                listViewCommand.Items.Add(new ListViewItem("New client connected!"));
            }));

            try
            {
                while (clientSocket.Connected)
                {
                    string text = "";
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        if (bytesReceived == 0)
                        {
                            // Client ngắt kết nối
                            break;
                        }
                        text += Encoding.ASCII.GetString(recv, 0, bytesReceived);
                    }
                    while (!text.EndsWith("\n"));

                    if (text.Length > 0)
                    {
                        string finalText = text.Trim();
                        listViewCommand.Invoke(new Action(() =>
                        {
                            listViewCommand.Items.Add(new ListViewItem(finalText));
                        }));
                    }

                }
            }
            catch (SocketException ex)
            {
                listViewCommand.Invoke(new Action(() =>
                {
                    listViewCommand.Items.Add(new ListViewItem("SocketException: " + ex.Message));
                }));
            }
            finally
            {
                clientSocket.Close();
                listenerSocket.Close();
            }
        }


    }
}
