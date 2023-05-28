using Salaros.Configuration;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace PteroController
{
    public partial class FrmLogin : Form
    {
        private static string accountinfo = Application.StartupPath + @"\account.ini";
        private static string settings = Application.StartupPath + @"\settings.ini";
        public static string user_api_key;
        public static string panel_url;
        public static string panel_pwd;
        //USER INFO
        public static string id;
        public static string admin;
        public static string username;
        public static string email;
        public static string firstName;
        public static string lastName;
        public static string language;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private async Task<bool> Login(string apiKey, Uri panelUri)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = panelUri;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("/api/client/account");

                    return response.IsSuccessStatusCode;
                }
                catch (HttpRequestException)
                {
                    return false;
                }
            }
        }

        private void loadSettings()
        {
            var cfg = new ConfigParser(settings);
            string allontop = cfg.GetValue("CONFIG", "always_on_top");
            if (allontop == "true")
            {
                this.TopMost = true;
            }
        }

        private async Task<string> GetUserInfo(string apiKey, Uri panelUri)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = panelUri;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("/api/client/account");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        return jsonResponse;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (HttpRequestException)
                {
                    return null;
                }
            }
        }
        private void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }
        private void CheckSession()
        {
            var cfg = new ConfigParser(accountinfo);
            string enableSession = cfg.GetValue("LOGIN", "remember_me");
            if (enableSession == "true")
            {
                string panelUrl = cfg.GetValue("LOGIN", "panel_url");
                string apiKey = cfg.GetValue("LOGIN", "api_key");
                string panelpwd = cfg.GetValue("LOGIN", "panel_pwd");
                txtpanelurl.Text = panelUrl;
                txtapikey.Text = apiKey;
                txtpanelpwd.Text = panelpwd;
                cbsavelogin.Checked = true;
                btnlogin.PerformClick();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CheckSession();
            loadSettings();
            lblappname.Text = "PteroController (" + Program.appversion + ")";
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtapikey.Text == "" || txtpanelurl.Text == "" || txtpanelpwd.Text == "")
            {
                Alert("Please fill in your pterodactyl connection info",FrmAlert.enmType.Error);
                return;
            }

            string apiKey = txtapikey.Text;
            string panelUrl = txtpanelurl.Text;

            if (!Uri.TryCreate(panelUrl, UriKind.Absolute, out Uri panelUri))
            {
                Alert("Invalid Pterodactyl URL.", FrmAlert.enmType.Warning);
                return;
            }

            bool loginSuccess = await Login(apiKey, panelUri);

            if (loginSuccess)
            {
                try
                {
                    string userInfo = await GetUserInfo(apiKey, panelUri);
                    if (userInfo != null)
                    {
                        JObject userObject = JObject.Parse(userInfo);
                        JObject attributes = (JObject)userObject["attributes"];
                        id = attributes["id"].ToString();
                        admin = attributes["admin"].ToString();
                        username = attributes["username"].ToString();
                        email = attributes["email"].ToString();
                        firstName = attributes["first_name"].ToString();
                        lastName = attributes["last_name"].ToString();
                        language = attributes["language"].ToString();

                        string userInformation = $"ID: {id}\nAdmin: {admin}\nUsername: {username}\nEmail: {email}\nFirst Name: {firstName}\nLast Name: {lastName}\nLanguage: {language}";
                        Console.WriteLine(userInformation);
                    }
                }
                catch
                {
                    Alert("Faild to get your data please check the panel url", FrmAlert.enmType.Warning);
                }

                if (cbsavelogin.Checked)
                {
                    var cfg = new ConfigParser(accountinfo);
                    cfg.SetValue("LOGIN", "remember_me", "true");
                    cfg.SetValue("LOGIN", "panel_url", panelUrl);
                    cfg.SetValue("LOGIN", "api_key", apiKey);
                    cfg.SetValue("LOGIN", "panel_pwd",txtpanelpwd.Text);
                    cfg.Save();
                    user_api_key = apiKey;
                    panel_url = panelUrl;
                    panel_pwd = txtpanelpwd.Text;
                }
                else
                {
                    var cfg = new ConfigParser(accountinfo);
                    cfg.SetValue("LOGIN", "remember_me", "false");
                    cfg.SetValue("LOGIN", "panel_url", panelUrl);
                    cfg.SetValue("LOGIN", "api_key", apiKey);
                    cfg.SetValue("LOGIN", "panel_pwd", txtpanelpwd.Text);
                    cfg.Save();
                    user_api_key = apiKey;
                    panel_url = panelUrl;
                    panel_pwd = txtpanelpwd.Text;
                }

                FrmMain x = new FrmMain();
                x.Show();
                Hide();
            }
            else
            {
                Alert("Login failed. Please check your API key", FrmAlert.enmType.Error);
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Q: Why do you need my panel password? \nA: Well we need it if you want to connect using SFTP");
        }
    }
}
