using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Add this namespace


namespace Lab4
{
    public partial class Exercise3Form : Form
    {
        public Exercise3Form()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string filePath = txtFile.Text;

            try
            {
                WebClient myClient = new WebClient();
                // Ghi nội dung về file
                myClient.DownloadFile(url, filePath);

                // Đọc nội dung file và hiển thị lên TextBox
                string htmlContent = File.ReadAllText(filePath);
                txtContent.Text = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
