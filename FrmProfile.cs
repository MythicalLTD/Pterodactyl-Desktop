using Newtonsoft.Json.Linq;
using PteroController.Properties;
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
    public partial class FrmProfile : Form
    {
        private static string accountinfo = Application.StartupPath + @"\account.ini";
        private static string settings = Application.StartupPath + @"\settings.ini";
        public FrmProfile()
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmMain x = new FrmMain();
            x.Show();
            this.Hide();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            lblusername.Text = "Username: "+FrmLogin.username;
            lblemail.Text = "Email: " + FrmLogin.email;
            lblfirstname.Text = "First Name: " + FrmLogin.firstName;
            lbllastname.Text = "Last Name: " + FrmLogin.lastName;
            LoadSettings();
        }
        private void LoadSettings()
        {
            var cfg = new ConfigParser(settings);
            string allontop = cfg.GetValue("CONFIG", "always_on_top");
            if (allontop == "true")
            {
                this.TopMost = true;
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var cfg = new ConfigParser(accountinfo);
            cfg.SetValue("LOGIN", "remember_me", "false");
            cfg.Save();
            FrmLogin x = new FrmLogin();
            x.Show();
            this.Hide();
        }
    }
}
