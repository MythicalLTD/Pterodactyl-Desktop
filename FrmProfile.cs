using Salaros.Configuration;
using System;
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
            PteroControllerWebServer.StopServer();
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
            lblusername.Text = "Username: " + FrmLogin.username;
            lblemail.Text = "Email: " + FrmLogin.email;
            lblfirstname.Text = "First Name: " + FrmLogin.firstName;
            lbllastname.Text = "Last Name: " + FrmLogin.lastName;
            LoadSettings();
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
    }
}
