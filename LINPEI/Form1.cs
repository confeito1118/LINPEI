using System.Diagnostics;

namespace LINPEI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://npo-yudu.jp/";
            OpenUrl(url);
        }

        /// <summary>
        /// URLを既定のブラウザで開く
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns>Process</returns>
        private Process OpenUrl(string url)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://npo-yudu.jp/5488120";
            OpenUrl(url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://npo-yudu.jp/work/";
            OpenUrl(url);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://npo-yudu.jp/work/5488120";
            OpenUrl(url);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "https://www.e-seikyuu.jp/";
            OpenUrl(url);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "https://mail.yahoo.co.jp/u/pc/f/";
            OpenUrl(url);
        }
    }
}
