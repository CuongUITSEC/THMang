// Exercise4Form.cs
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4
{
    public partial class Exercise4Form : Form
    {
        public Exercise4Form()
        {
            InitializeComponent();
        }

        private void Exercise4Form_Load(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
            txtUrl.Text = "https://www.google.com";
            NavigateToUrl();
        }

        private void NavigateToUrl()
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url)) return;

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                url = "http://" + url;

            try
            {
                webBrowser.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy cập URL: " + ex.Message);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateToUrl();
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                NavigateToUrl();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnDownloadHtml_Click(object sender, EventArgs e)
        {
            if (webBrowser.Url == null) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML Files|*.html";
            saveFileDialog.Title = "Lưu file HTML";
            saveFileDialog.FileName = "page.html";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("user-agent", "Mozilla/5.0");
                        string html = client.DownloadString(webBrowser.Url.ToString());
                        File.WriteAllText(saveFileDialog.FileName, html);
                    }
                    MessageBox.Show("Đã lưu HTML thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải HTML: " + ex.Message);
                }
            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            if (webBrowser.Document != null)
            {
                string html = webBrowser.DocumentText;
                SourceViewerForm viewer = new SourceViewerForm();
                viewer.SetSourceCode(html);
                viewer.Show();
            }
        }

        private void btnDownloadAll_Click(object sender, EventArgs e)
        {
            if (webBrowser.Url == null)
            {
                MessageBox.Show("Không có trang web nào đang hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK)
                return;

            string folderPath = folderDialog.SelectedPath;
            string url = webBrowser.Url.ToString();

            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/5.0");

                string html = client.DownloadString(url);
                string mainFilePath = Path.Combine(folderPath, "index.html");
                File.WriteAllText(mainFilePath, html);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                int fileCount = 0;

                var imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");
                if (imgNodes != null)
                {
                    foreach (var node in imgNodes)
                        fileCount += DownloadResource(node, "src", url, folderPath, client);
                }

                var cssNodes = doc.DocumentNode.SelectNodes("//link[@rel='stylesheet' and @href]");
                if (cssNodes != null)
                {
                    foreach (var node in cssNodes)
                        fileCount += DownloadResource(node, "href", url, folderPath, client);
                }

                var scriptNodes = doc.DocumentNode.SelectNodes("//script[@src]");
                if (scriptNodes != null)
                {
                    foreach (var node in scriptNodes)
                        fileCount += DownloadResource(node, "src", url, folderPath, client);
                }

                MessageBox.Show($"\u0110\u00e3 t\u1ea3i th\u00e0nh c\u00f4ng HTML v\u00e0 {fileCount} t\u00e0i nguy\u00ean (\u1ea3nh, CSS, JS)!", "Th\u00e0nh c\u00f4ng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Tải thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DownloadResource(HtmlNode node, string attributeName, string pageUrl, string folderPath, WebClient client)
        {
            try
            {
                string resourceUrl = node.GetAttributeValue(attributeName, null);
                if (string.IsNullOrEmpty(resourceUrl)) return 0;

                if (!resourceUrl.StartsWith("http"))
                {
                    Uri baseUri = new Uri(pageUrl);
                    resourceUrl = new Uri(baseUri, resourceUrl).AbsoluteUri;
                }

                string fileName = Path.GetFileName(new Uri(resourceUrl).LocalPath);
                if (string.IsNullOrWhiteSpace(fileName))
                    fileName = "file_" + Guid.NewGuid().ToString("N").Substring(0, 8);

                string savePath = Path.Combine(folderPath, fileName);

                if (!File.Exists(savePath))
                {
                    client.DownloadFile(resourceUrl, savePath);
                    return 1;
                }
            }
            catch
            {
                // Bỏ qua file nếu lỗi
            }
            return 0;
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtUrl.Text = webBrowser.Url.ToString();
            this.Text = $"{webBrowser.Document?.Title} - Trình duyệt Lab 4";
        }
    }
}
