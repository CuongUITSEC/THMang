using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4
{
    public class SourceViewerForm : Form
    {
        private readonly RichTextBox rtbSource;
        private readonly Button btnClose;

        public SourceViewerForm()
        {
            // Thiết lập form
            this.Text = "Xem mã nguồn";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;

            // Tạo và cấu hình RichTextBox
            rtbSource = new RichTextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 10),
                ReadOnly = true,
                WordWrap = false,
                ScrollBars = RichTextBoxScrollBars.Both,
                BackColor = Color.White,
                ForeColor = Color.Black
            };

            // Tạo và cấu hình nút đóng
            btnClose = new Button
            {
                Text = "Đóng",
                Dock = DockStyle.Bottom,
                Height = 40,
                Font = new Font("Arial", 10),
                BackColor = SystemColors.Control,
                FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += (s, e) => this.Close();

            // Thêm controls vào form
            this.Controls.Add(rtbSource);
            this.Controls.Add(btnClose);

            // Xử lý phím tắt
            this.KeyPreview = true;
            this.KeyDown += (s, e) => { if (e.KeyCode == Keys.Escape) this.Close(); };
        }

        public void SetSourceCode(string sourceCode)
        {
            rtbSource.Text = sourceCode;
            rtbSource.SelectionStart = 0;
            rtbSource.SelectionLength = 0;
        }
    }
}