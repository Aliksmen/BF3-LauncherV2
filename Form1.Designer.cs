namespace BF3_Launcher_V2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.geckoWebBrowser3 = new Skybound.Gecko.GeckoWebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmd_einstellsp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_origin = new System.Windows.Forms.ComboBox();
            this.cmd_Sucheorigin = new System.Windows.Forms.Button();
            this.check_autoende = new System.Windows.Forms.CheckBox();
            this.check_autostart = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.check_autologin = new System.Windows.Forms.CheckBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_url = new System.Windows.Forms.ComboBox();
            this.cmd_zurueck = new System.Windows.Forms.Button();
            this.cmd_vor = new System.Windows.Forms.Button();
            this.cmd_los = new System.Windows.Forms.Button();
            this.panel_Browser = new System.Windows.Forms.Panel();
            this.check_size = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_Browser.SuspendLayout();
            this.SuspendLayout();
            // 
            // geckoWebBrowser3
            // 
            this.geckoWebBrowser3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser3.Location = new System.Drawing.Point(12, 38);
            this.geckoWebBrowser3.Name = "geckoWebBrowser3";
            this.geckoWebBrowser3.Size = new System.Drawing.Size(1129, 590);
            this.geckoWebBrowser3.TabIndex = 0;
            this.geckoWebBrowser3.StatusTextChanged += new System.EventHandler(this.geckoWebBrowser3_StatusTextChanged);
            this.geckoWebBrowser3.ProgressChanged += new Skybound.Gecko.GeckoProgressEventHandler(this.geckoWebBrowser3_ProgressChanged);
            this.geckoWebBrowser3.Click += new System.EventHandler(this.geckoWebBrowser3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 400);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_size);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.cmd_einstellsp);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_origin);
            this.groupBox2.Controls.Add(this.cmd_Sucheorigin);
            this.groupBox2.Controls.Add(this.check_autoende);
            this.groupBox2.Controls.Add(this.check_autostart);
            this.groupBox2.Location = new System.Drawing.Point(3, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 221);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Einstellungen";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Browsermode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmd_einstellsp
            // 
            this.cmd_einstellsp.Location = new System.Drawing.Point(0, 192);
            this.cmd_einstellsp.Name = "cmd_einstellsp";
            this.cmd_einstellsp.Size = new System.Drawing.Size(241, 23);
            this.cmd_einstellsp.TabIndex = 17;
            this.cmd_einstellsp.Text = "Einstellungen speichern";
            this.cmd_einstellsp.UseVisualStyleBackColor = true;
            this.cmd_einstellsp.Click += new System.EventHandler(this.cmd_einstellsp_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Starte Origin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "Manuelle Suche";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pfad zu Origin";
            // 
            // txt_origin
            // 
            this.txt_origin.FormattingEnabled = true;
            this.txt_origin.Location = new System.Drawing.Point(6, 87);
            this.txt_origin.Name = "txt_origin";
            this.txt_origin.Size = new System.Drawing.Size(226, 21);
            this.txt_origin.TabIndex = 13;
            this.txt_origin.Text = "Pfad zu Origin";
            // 
            // cmd_Sucheorigin
            // 
            this.cmd_Sucheorigin.Location = new System.Drawing.Point(6, 114);
            this.cmd_Sucheorigin.Name = "cmd_Sucheorigin";
            this.cmd_Sucheorigin.Size = new System.Drawing.Size(114, 25);
            this.cmd_Sucheorigin.TabIndex = 12;
            this.cmd_Sucheorigin.Text = "Automatische Suche";
            this.cmd_Sucheorigin.UseVisualStyleBackColor = true;
            this.cmd_Sucheorigin.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // check_autoende
            // 
            this.check_autoende.AutoSize = true;
            this.check_autoende.Location = new System.Drawing.Point(6, 42);
            this.check_autoende.Name = "check_autoende";
            this.check_autoende.Size = new System.Drawing.Size(102, 17);
            this.check_autoende.TabIndex = 1;
            this.check_autoende.Text = "Autoende Origin";
            this.check_autoende.UseVisualStyleBackColor = true;
            // 
            // check_autostart
            // 
            this.check_autostart.AutoSize = true;
            this.check_autostart.Location = new System.Drawing.Point(6, 19);
            this.check_autostart.Name = "check_autostart";
            this.check_autostart.Size = new System.Drawing.Size(98, 17);
            this.check_autostart.TabIndex = 0;
            this.check_autostart.Text = "Autostart Origin";
            this.check_autostart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.check_autologin);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login-Daten";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(5, 80);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(226, 20);
            this.txt_Pass.TabIndex = 11;
            this.txt_Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Pass_MouseClick);
            this.txt_Pass.Enter += new System.EventHandler(this.txt_Pass_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Mail/Benutzername";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 106);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(151, 29);
            this.button9.TabIndex = 0;
            this.button9.Text = "LogIn";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwort";
            // 
            // check_autologin
            // 
            this.check_autologin.AutoSize = true;
            this.check_autologin.Location = new System.Drawing.Point(157, 113);
            this.check_autologin.Name = "check_autologin";
            this.check_autologin.Size = new System.Drawing.Size(75, 17);
            this.check_autologin.TabIndex = 2;
            this.check_autologin.Text = "AutoLogIn";
            this.check_autologin.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(6, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(226, 20);
            this.txt_name.TabIndex = 10;
            this.txt_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_name_MouseClick);
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1153, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(804, 634);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 16);
            this.progressBar1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_url
            // 
            this.txt_url.FormattingEnabled = true;
            this.txt_url.Location = new System.Drawing.Point(71, 7);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(888, 21);
            this.txt_url.TabIndex = 5;
            this.txt_url.Enter += new System.EventHandler(this.txt_url_Enter);
            // 
            // cmd_zurueck
            // 
            this.cmd_zurueck.Location = new System.Drawing.Point(6, 5);
            this.cmd_zurueck.Name = "cmd_zurueck";
            this.cmd_zurueck.Size = new System.Drawing.Size(30, 23);
            this.cmd_zurueck.TabIndex = 6;
            this.cmd_zurueck.Text = "<-";
            this.cmd_zurueck.UseVisualStyleBackColor = true;
            this.cmd_zurueck.Click += new System.EventHandler(this.cmd_zurueck_Click);
            // 
            // cmd_vor
            // 
            this.cmd_vor.Location = new System.Drawing.Point(35, 5);
            this.cmd_vor.Name = "cmd_vor";
            this.cmd_vor.Size = new System.Drawing.Size(30, 23);
            this.cmd_vor.TabIndex = 7;
            this.cmd_vor.Text = "->";
            this.cmd_vor.UseVisualStyleBackColor = true;
            this.cmd_vor.Click += new System.EventHandler(this.cmd_vor_Click);
            // 
            // cmd_los
            // 
            this.cmd_los.Location = new System.Drawing.Point(965, 5);
            this.cmd_los.Name = "cmd_los";
            this.cmd_los.Size = new System.Drawing.Size(46, 23);
            this.cmd_los.TabIndex = 8;
            this.cmd_los.Text = "LOS!";
            this.cmd_los.UseVisualStyleBackColor = true;
            this.cmd_los.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel_Browser
            // 
            this.panel_Browser.Controls.Add(this.cmd_los);
            this.panel_Browser.Controls.Add(this.cmd_vor);
            this.panel_Browser.Controls.Add(this.cmd_zurueck);
            this.panel_Browser.Controls.Add(this.txt_url);
            this.panel_Browser.Location = new System.Drawing.Point(130, 4);
            this.panel_Browser.Name = "panel_Browser";
            this.panel_Browser.Size = new System.Drawing.Size(1011, 34);
            this.panel_Browser.TabIndex = 9;
            this.panel_Browser.Visible = false;
            // 
            // check_size
            // 
            this.check_size.AutoSize = true;
            this.check_size.Location = new System.Drawing.Point(6, 146);
            this.check_size.Name = "check_size";
            this.check_size.Size = new System.Drawing.Size(142, 17);
            this.check_size.TabIndex = 19;
            this.check_size.Text = "Merken der Fenstergöße";
            this.check_size.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1153, 651);
            this.Controls.Add(this.panel_Browser);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.geckoWebBrowser3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BF3-Launcher V2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_Browser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Skybound.Gecko.GeckoWebBrowser geckoWebBrowser3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmd_Sucheorigin;
        private System.Windows.Forms.CheckBox check_autologin;
        private System.Windows.Forms.CheckBox check_autoende;
        private System.Windows.Forms.CheckBox check_autostart;
        private System.Windows.Forms.ComboBox txt_origin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmd_einstellsp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox txt_url;
        private System.Windows.Forms.Button cmd_zurueck;
        private System.Windows.Forms.Button cmd_vor;
        private System.Windows.Forms.Button cmd_los;
        private System.Windows.Forms.Panel panel_Browser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.CheckBox check_size;
    }
}

