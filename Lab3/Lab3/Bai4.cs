using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai4_server server = new Bai4_server();
            server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai4_client bai4_Client = new Bai4_client();
            bai4_Client.Show();
        }
    }
}
