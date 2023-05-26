using Salaros.Configuration;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace PteroControler
{
    public partial class FrmLogin : Form
    {
        private static string accountinfo = Application.StartupPath + @"\account.ini";
        public static string user_api_key;
        public static string panel_url;

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

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtapikey.Text == "")
            {
                MessageBox.Show("Please fill in your Pterodactyl client API key!");
                return;
            }
            if (txtpanelurl.Text == "")
            {
                MessageBox.Show("Please fill in the Pterodactyl URL");
                return;
            }

            string apiKey = txtapikey.Text;
            string panelUrl = txtpanelurl.Text;

            if (!Uri.TryCreate(panelUrl, UriKind.Absolute, out Uri panelUri))
            {
                MessageBox.Show("Invalid Pterodactyl URL. Please provide a valid URL.");
                return;
            }

            bool loginSuccess = await Login(apiKey, panelUri);

            if (loginSuccess)
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

                if (cbsavelogin.Checked)
                {
                    var cfg = new ConfigParser(accountinfo);
                    cfg.SetValue("LOGIN", "remember_me", "true");
                    cfg.SetValue("LOGIN", "panel_url", panelUrl);
                    cfg.SetValue("LOGIN", "api_key", apiKey);
                    cfg.Save();
                    user_api_key = apiKey;
                    panel_url = panelUrl;
                }
                else
                {
                    var cfg = new ConfigParser(accountinfo);
                    cfg.SetValue("LOGIN", "remember_me", "false");
                    cfg.SetValue("LOGIN", "panel_url", panelUrl);
                    cfg.SetValue("LOGIN", "api_key", apiKey);
                    cfg.Save();
                    user_api_key = apiKey;
                    panel_url = panelUrl;
                }

                FrmServerList x = new FrmServerList();
                x.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your API key and try again.");
            }
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

        private void CheckSession()
        {
            var cfg = new ConfigParser(accountinfo);
            string enableSession = cfg.GetValue("LOGIN", "remember_me");
            if (enableSession == "true")
            {
                string panelUrl = cfg.GetValue("LOGIN", "panel_url");
                string apiKey = cfg.GetValue("LOGIN", "api_key");
                txtpanelurl.Text = panelUrl;
                txtapikey.Text = apiKey;
                cbsavelogin.Checked = true;
                btnlogin.PerformClick();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CheckSession();
        }
    }
}
