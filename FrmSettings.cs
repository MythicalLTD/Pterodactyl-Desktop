using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PteroController
{
    public partial class FrmSettings : Form
    {
        private static string settings = Application.StartupPath + @"\settings.ini";
        private static string accountinfo = Application.StartupPath + @"\account.ini";
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmSettings x = new FrmSettings();
            x.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            FrmSettings x = new FrmSettings();
            x.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                var cfg = new ConfigParser(settings);
                if (cballontop.Checked == true)
                {
                    cfg.SetValue("CONFIG", "always_on_top", "true");
                    cfg.Save();
                }
                else if (cballontop.Checked == false)
                {
                    cfg.SetValue("CONFIG", "always_on_top", "false");
                    cfg.Save();
                }
                if (cbdevmode.Checked == true)
                {
                    cfg.SetValue("CONFIG", "devmode", "true");
                    cfg.Save();
                }
                else if (cbdevmode.Checked == false)
                {
                    cfg.SetValue("CONFIG", "devmode", "true");
                    cfg.Save();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("[{0:HH:mm:ss}] (SETTINGS) An error occurred: " + ex.Message, DateTime.Now);
            }

        }
        private void LoadSettings()
        {
            try
            {
                var cfg = new ConfigParser(settings);
                string allontop = cfg.GetValue("CONFIG", "always_on_top");
                if (allontop == "true")
                {
                    this.TopMost = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (SETTINGS) An error occurred: " + ex.Message, DateTime.Now);
            }
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                var cfg = new ConfigParser(accountinfo);
                cfg.SetValue("LOGIN", "remember_me", "false");
                cfg.Save();
            }
            catch (Exception ex)
            {
                Console.Write("[{0:HH:mm:ss}] (SESSIONS) An error occurred: " + ex.Message, DateTime.Now);
            }
            FrmLogin x = new FrmLogin();
            x.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmProfile x = new FrmProfile();
            x.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            FrmProfile x = new FrmProfile();
            x.Show();
            this.Hide();
        }

        private void sidenav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmMain x = new FrmMain();
            x.Show();
            this.Hide();
        }
    }
}
