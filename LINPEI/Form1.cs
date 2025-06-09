using System.Diagnostics;

// NuGet HTML
using HtmlAgilityPack;

namespace LINPEI
{
    public partial class Form1 : Form
    {
        public const int SOFT_VERSION = 160;
        public bool SOFT_VERSION_FLAG = false;

        public Form1()
        {
            InitializeComponent();
            versionCheck();
        }

        public void versionCheck()
        {
            // 最新バージョン情報の確認
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load("https://npo-yudu.jp/pei/homepei.html");
            // var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/version");
            // HTMLタグ付き <title>Yahoo</title>
            // MessageBox.Show("Node Name: " + node.Name + "\n" + node.OuterHtml);
            // HTMLタグ無し Yahoo
            // MessageBox.Show("Node Name: " + node.Name + "\n" + node.InnerText);
            int test = Int32.Parse(node.InnerText);
            if (test == SOFT_VERSION)
            {
                MessageBox.Show("ご利用のバージョンは最新版です");
            }
            else
            {
                MessageBox.Show("ご利用のバージョンは最新版ではありません。\n最新版をダウンロードしてください");
                this.Close();
            }
        }

        private Process OpenUrl(string url)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenUrl("https://npo-yudu.jp/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenUrl("https://npo-yudu.jp/5488120");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenUrl("https://npo-yudu.jp/work/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenUrl("https://npo-yudu.jp/work/5488120");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.e-seikyuu.jp/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenUrl("https://mail.yahoo.co.jp/u/pc/f/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.hellowork.mhlw.go.jp/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.fukushi-work.jp/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.kansaimiraibank.co.jp/hojin/b_direct/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.canbill.jp/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenUrl("http://www.kusatsu_yogo-sh.shiga-ec.ed.jp/gyouziyotei.html");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenUrl("https://colibri.jp/users/sign_in");
        }

        private void 使い方HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
