using Newtonsoft.Json;
using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace PteroController
{
    public partial class FrmMain : Form
    {
        private HttpClient httpClient;
        private static string accountinfo = Application.StartupPath + @"\account.ini";
        private static string settings = Application.StartupPath + @"\settings.ini";
        public FrmMain()
        {
            InitializeComponent();
            serverListBox.SelectedIndex = -1;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {FrmLogin.user_api_key}");
        }
        private bool isFirstLoad = true;
        private async void FrmServerList_Load(object sender, EventArgs e)
        {
            loadSettings();
            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(FrmLogin.panel_url + "/api/client");
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                PterodactylApiResponse apiResponse = JsonConvert.DeserializeObject<PterodactylApiResponse>(jsonResponse);
                List<ServerData> serverDataList = apiResponse.Data;
                List<string> serverNames = new List<string>();
                foreach (var serverData in serverDataList)
                {
                    string serverName = $"{serverData.Attributes.Name} ({serverData.Attributes.Identifier})";
                    serverNames.Add(serverName);
                }
                serverListBox.DataSource = serverNames;
                serverListBox.ClearSelected();
                isFirstLoad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (SERVER LIST) An error occurred: " + ex.Message + "", DateTime.Now);
            }
        }
        private void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }
        public class PterodactylApiResponse
        {
            public List<ServerData> Data { get; set; }
        }
        private void loadSettings()
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

        public class ServerData
        {
            public ServerAttributes Attributes { get; set; }
        }

        public class ServerAttributes
        {
            public string Identifier { get; set; }
            public string Name { get; set; }
        }

        private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isFirstLoad)
                {
                    isFirstLoad = false;
                    return;
                }

                if (serverListBox.SelectedItem != null && serverListBox.SelectedItem is string selectedServerName)
                {
                    string identifier = selectedServerName.Substring(selectedServerName.IndexOf('(') + 1);
                    identifier = identifier.TrimEnd(')');
                    FrmServerController serverDetailsForm = new FrmServerController(identifier);
                    serverDetailsForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (SERVER LIST) An error occurred: " + ex.Message, DateTime.Now);
                Alert("We are sorry but we can't load the servers", FrmAlert.enmType.Error);
            }

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

        private void serverListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            FrmProfile x = new FrmProfile();
            x.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmProfile x = new FrmProfile();
            x.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            FrmSettings x = new FrmSettings();
            x.Show();
            this.Hide();
        }

        private void sidenav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmSettings x = new FrmSettings();
            x.Show();
            this.Hide();
        }

        private void serverListBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (serverListBox.SelectedItem != null && serverListBox.SelectedItem is string selectedServerName)
                {
                    string identifier = selectedServerName.Substring(selectedServerName.IndexOf('(') + 1);
                    identifier = identifier.TrimEnd(')');
                    FrmServerController serverDetailsForm = new FrmServerController(identifier);
                    serverDetailsForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (SERVER LIST) An error occurred:" + ex.Message, DateTime.Now);
            }

        }
    }

}
