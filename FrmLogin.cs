using Newtonsoft.Json.Linq;
using Salaros.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           try
            {
                var cfg = new ConfigParser(accountinfo);
                string enableSession = cfg.GetValue("LOGIN", "remember_me");
                if (enableSession == "true")
                {
                    string panelUrl = Decrypt(cfg.GetValue("LOGIN", "panel_url"));
                    string apiKey = Decrypt(cfg.GetValue("LOGIN", "api_key"));
                    string panelpwd = Decrypt(cfg.GetValue("LOGIN", "panel_pwd"));

                    txtpanelurl.Text = panelUrl;
                    txtapikey.Text = apiKey;
                    txtpanelpwd.Text = panelpwd;
                    cbsavelogin.Checked = true;
                    btnlogin.PerformClick();
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("[{0:HH:mm:ss}] (SESSIONS) Faild to load account data: ",ex.Message,DateTime.Now);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CheckSession();
            loadSettings();
            lblappname.Text = "PteroController (" + Program.appversion + ")";
        }
        private string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            string encryptedText = Convert.ToBase64String(plainTextBytes);
            return encryptedText;
        }

        private string Decrypt(string encryptedText)
        {
            byte[] encryptedTextBytes = Convert.FromBase64String(encryptedText);
            string decryptedText = Encoding.UTF8.GetString(encryptedTextBytes);
            return decryptedText;
        }
        private async void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtapikey.Text == "" || txtpanelurl.Text == "" || txtpanelpwd.Text == "")
            {
                Alert("Please fill in your pterodactyl connection info", FrmAlert.enmType.Error);
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
                        Console.WriteLine("[{0:HH:mm:ss}] (LOGIN) Logged in!",DateTime.Now);
                    }
                    else
                    {
                        Alert("Faild to get your data please check the panel url", FrmAlert.enmType.Warning);
                    }
                }
                catch (Exception ex)
                {
                    Alert("Faild to get your data please check the panel url", FrmAlert.enmType.Warning);
                    Console.WriteLine("[{0:HH:mm:ss}] (LOGIN) Faild to connect:", ex.Message, DateTime.Now);
                }

                if (cbsavelogin.Checked)
                {
                    try
                    {
                        var cfg = new ConfigParser(accountinfo);
                        cfg.SetValue("LOGIN", "remember_me", "true");
                        string e_panel_url = Encrypt(panelUrl);
                        cfg.SetValue("LOGIN", "panel_url", e_panel_url);
                        string e_apiKey = Encrypt(apiKey);
                        cfg.SetValue("LOGIN", "api_key", e_apiKey);
                        string e_pass = Encrypt(txtpanelpwd.Text);
                        cfg.SetValue("LOGIN", "panel_pwd", e_pass);
                        cfg.Save();
                        user_api_key = apiKey;
                        panel_url = panelUrl;
                        panel_pwd = txtpanelpwd.Text;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[{0:HH:mm:ss}] (SESSIONS) Faild to load account data: ", ex.Message, DateTime.Now);
                    }
                }
                else
                {
                    try
                    {
                        var cfg = new ConfigParser(accountinfo);
                        cfg.SetValue("LOGIN", "remember_me", "false");
                        string e_panel_url = Encrypt(panelUrl);
                        cfg.SetValue("LOGIN", "panel_url", e_panel_url);
                        string e_apiKey = Encrypt(apiKey);
                        cfg.SetValue("LOGIN", "api_key", e_apiKey);
                        string e_pass = Encrypt(txtpanelpwd.Text);
                        cfg.SetValue("LOGIN", "panel_pwd", e_pass);
                        cfg.Save();
                        user_api_key = apiKey;
                        panel_url = panelUrl;
                        panel_pwd = txtpanelpwd.Text;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[{0:HH:mm:ss}] (SESSIONS) Faild to load account data: ", ex.Message, DateTime.Now);
                    }
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
            PteroControllerWebServer.StopServer();
            Application.Exit();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
