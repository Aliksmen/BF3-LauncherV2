using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Net;
using Skybound.Gecko;
using System.Drawing.Drawing2D;



namespace BF3_Launcher_V2
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);


        public Form1()
        {
            string ProfileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Gecko\\DefaultProfile";

            if (!Directory.Exists(ProfileDirectory))
            {
                Directory.CreateDirectory(ProfileDirectory);
            }
            Xpcom.ProfileDirectory = ProfileDirectory;

            string xrPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            xrPath = xrPath.Substring(0, xrPath.LastIndexOf("\\") + 1) + "\\xulrunner";
            Xpcom.Initialize(xrPath);


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            // Set to no text.
            txt_Pass.Text = "";
            // The password character is an asterisk.
            txt_Pass.PasswordChar = '*';
            einstellungen_laden();


            if (Properties.Settings.Default.autologin == true)
            {
                button9.Enabled = false;
                login(txt_name.Text, txt_Pass.Text, "de");
            }

            if (Properties.Settings.Default.autostart == true)
            {
                if (origin_isrunning() == false)
                {
                    origin_starten();
                }

            }



            if (origin_isrunning() == true)
            {
                button3.Text = "Beende Origin";
            }
            else
            {
                button3.Text = "Starte Origin";
            }


            geckoWebBrowser3.Navigate("https://battlelog.battlefield.com/bf3/de/gate/login/");
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] parameters = (String[])e.Argument;
            string email = parameters[0];
            string pass = parameters[1];
            string locale = parameters[2];
            string url = "https://battlelog.battlefield.com/bf3/de/gate/login/";
            string Parameters = string.Format("redirect=|{0}|bf3|&email={1}&password={2}&submit={3}&remember={4}", locale, email, pass, "Anmelden", "1");

            CookieContainer _cookieContainer = new CookieContainer();

            //login und auslesen des Cookie
            HttpWebRequest _request1 = (HttpWebRequest)WebRequest.Create(url);
            _request1.Method = "POST";
            _request1.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            _request1.AllowAutoRedirect = false;
            _request1.CookieContainer = _cookieContainer;
            _request1.ContentType = "application/x-www-form-urlencoded";
            _request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:7.0.1) Gecko/20100101 Firefox/7.0.1";
            _request1.KeepAlive = true;
            _request1.Referer = string.Format("http://battlelog.battlefield.com/bf3/{0}/gate/?returnUrl=|bf3|{0}|", locale);

            string _postData = Parameters;
            byte[] _byteArray = Encoding.UTF8.GetBytes(_postData);
            _request1.ContentLength = _byteArray.Length;

            Stream _reqStream = _request1.GetRequestStream();
            _reqStream.Write(_byteArray, 0, _byteArray.Length);
            _reqStream.Close();

            HttpWebResponse _response1 = (HttpWebResponse)_request1.GetResponse();
            CookieCollection _cookieCollection = new CookieCollection();
            foreach (Cookie _cook in _response1.Cookies)
            {
                _cookieCollection.Add(_cook);
            }
            WebHeaderCollection headers = _response1.Headers;
            string _location = headers.Get("location");

            _response1.Close();

            //Erzeuge Cookiestring für Webbrowser Control
            StringBuilder sb = new StringBuilder();
            foreach (Cookie cookie in _cookieCollection)
            {
                sb.Append(String.Format("{0}={1}; ", cookie.Name, cookie.Value));
            }
            //Entferne "; " am ende Des letzten Cookie
            sb.Remove(sb.Length - 2, 2);
            e.Result = new string[] { sb.ToString(), _location, string.Format("http://battlelog.battlefield.com/bf3/{0}/gate/?returnUrl=|bf3|{0}|", locale) };

        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] results = (string[])e.Result;
            string cookie = results[0];
            string location = results[1];
            string referrer = results[2];
            geckoWebBrowser3.Document.Cookie = cookie;
            FakeGeckoMimeStream postData = new FakeGeckoMimeStream();
            geckoWebBrowser3.Navigate(location, GeckoLoadFlags.IsLink, referrer, postData);
            button9.Enabled = true;
        }

        private class FakeGeckoMimeStream : Skybound.Gecko.GeckoMIMEInputStream
        {
            public FakeGeckoMimeStream()
            {
                base.InputStream = null;
            }
        }

        private void login(String email, string pass, string locale)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync(new string[] { email, pass, locale });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            login(txt_name.Text, txt_Pass.Text, "de");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            { panel1.Visible = false; }
            else
            { panel1.Visible = true; }
        }

        private void einstellungen_speichern()
        {
            Properties.Settings.Default.name = Encryption.EncryptString(txt_name.Text, "Lokoma79");
            Properties.Settings.Default.pass = Encryption.EncryptString(txt_Pass.Text, "Detowe52");
            Properties.Settings.Default.origin = txt_origin.Text;
            Properties.Settings.Default.autoende = check_autoende.Checked;
            Properties.Settings.Default.autostart = check_autostart.Checked;
            Properties.Settings.Default.autologin = check_autologin.Checked;
            Properties.Settings.Default.windowsize = this.ClientSize;
            Properties.Settings.Default.windowsize_merken = check_size.Checked;
            Properties.Settings.Default.Save();
        }


        private void einstellungen_laden()
        {
            txt_name.Text = Encryption.DecryptString(Properties.Settings.Default.name, "Lokoma79");
            txt_Pass.Text = Encryption.DecryptString(Properties.Settings.Default.pass, "Detowe52");
            txt_origin.Text = Properties.Settings.Default.origin;
            check_autoende.Checked = Properties.Settings.Default.autoende;
            check_autostart.Checked = Properties.Settings.Default.autostart;
            check_autologin.Checked = Properties.Settings.Default.autologin;
            check_size.Checked = Properties.Settings.Default.windowsize_merken;
            if(Properties.Settings.Default.windowsize_merken==true) this.ClientSize = Properties.Settings.Default.windowsize;
        }


        private void origin_starten()
        {
            button3.Text = "Beende Origin";

            Process Origin = new Process();
            Origin.StartInfo.FileName = Properties.Settings.Default.origin;
            Origin.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            Origin.StartInfo.CreateNoWindow = true;
            Origin.Start();

            IntPtr hwnd = Origin.MainWindowHandle;
            const int SW_SHOWMINIMIZED = 6;
            ShowWindow(hwnd, SW_SHOWMINIMIZED);

        }
        

        private bool origin_isrunning()
        {
            Process[] MatchingProcesses = Process.GetProcessesByName("Origin");
            if (MatchingProcesses.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void origin_beenden()
        {
            button3.Text = "Starte Origin";
            
                Process[] MatchingProcesses = Process.GetProcessesByName("Origin");
                if (MatchingProcesses.Length > 0)
                {
                    foreach (Process p in MatchingProcesses)
                    {
                        p.Kill();
                    }
                }
            

        }
        

        

        private void geckoWebBrowser3_ProgressChanged(object sender, GeckoProgressEventArgs e)
        { 
            txt_url.Text = geckoWebBrowser3.Url.ToString();            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            einstellungen_speichern();

            if (Properties.Settings.Default.autoende == true)
            {
                if (origin_isrunning() == true)
                {
                    origin_beenden();
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Enabled = false;
            DirSearch_AllDrives();
            this.Enabled = true;

            if(String.IsNullOrEmpty(txt_origin.Text))
            {
                if (MessageBox.Show("Origin konnte nicht automatisch gefunden werden, wollen Sie selbst danach suchen?",
                 "Origin nicht gefunden!",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    manuelle_suche();
                }
            }

        }

        void manuelle_suche()
        {
            openFileDialog1.Filter = "Origin|Origin.exe";
            openFileDialog1.Title = "Select Origin.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_origin.Text = openFileDialog1.FileName;
            }
        }

        void DirSearch_AllDrives()
        {
            System.IO.DriveInfo[] allDrives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo d in allDrives)
            {
                if (d.IsReady)
                {
                    DirSearch(d.Name);
                }
            }
        }



        void DirSearch(string sDir)
        {

            foreach (string d in Directory.GetDirectories(sDir))
            {
                try
                {
                    foreach (string f in Directory.GetFiles(d, "Origin.exe"))
                    {
                        txt_origin.Items.Add(f);
                        txt_origin.Text = f;

                    }
                    DirSearch(d);
                }
                catch (System.Exception)
                {

                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            manuelle_suche();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (origin_isrunning() == false) origin_starten();
            else origin_beenden();
        }

        private void cmd_einstellsp_Click(object sender, EventArgs e)
        {
            einstellungen_speichern();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel_Browser.Visible = true;
            }

            else
            {
                panel_Browser.Visible = false;
            }
        }

        private void geckoWebBrowser3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            borwse(txt_url.Text);
        }

        private void borwse(string url)
        {
            geckoWebBrowser3.Navigate(url);
            txt_url.Items.Add(txt_url.Text);
        }

        private void cmd_zurueck_Click(object sender, EventArgs e)
        {
            geckoWebBrowser3.GoBack();
        }

        private void geckoWebBrowser3_StatusTextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = geckoWebBrowser3.StatusText;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmd_vor_Click(object sender, EventArgs e)
        {
            geckoWebBrowser3.GoForward();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            txt_name.Text = txt_name.Text.Trim();
            
        }

        private void txt_Pass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txt_Pass.Text = txt_Pass.Text.Trim();
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            txt_name.SelectionStart = 0;
            txt_name.SelectionLength = txt_name.Text.Length;
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            txt_Pass.SelectionStart = 0;
            txt_Pass.SelectionLength = txt_Pass.Text.Length;
        }

        private void txt_url_Enter(object sender, EventArgs e)
        {
            txt_url.SelectionStart = 0;
            txt_url.SelectionLength = txt_url.Text.Length;
        }

        private void txt_name_MouseClick(object sender, MouseEventArgs e)
        {
            txt_name.SelectionStart = 0;
            txt_name.SelectionLength = txt_name.Text.Length;
        }

        private void txt_Pass_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Pass.SelectionStart = 0;
            txt_Pass.SelectionLength = txt_Pass.Text.Length;
        }

        private void geckoWebBrowser3_Navigating(object sender, GeckoNavigatingEventArgs e)
        {
            
        }

        private void geckoWebBrowser3_Navigated(object sender, GeckoNavigatedEventArgs e)
        {
           
        }

        

        
        
    }
}
    


