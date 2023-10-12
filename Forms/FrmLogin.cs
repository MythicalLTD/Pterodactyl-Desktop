using Newtonsoft.Json;
using Pterodactyl.Handlers;
using System.Net.Http.Headers;

namespace Pterodactyl.Forms
{
    public partial class FrmLogin : Form
    {
        private bool IsDirectLogin;
        public FrmLogin(bool DirectLogin)
        {
            InitializeComponent();
            this.IsDirectLogin = DirectLogin;
        }

        private async void btnaddsession_Click(object sender, EventArgs e)
        {
            if (txtpanelurl.Text == "" || txtpanelapikey.Text == "" || txtpanelname.Text == "" || txtpanelpwd.Text == "")
            {
                Program.Alert("Please fill in all required information", FrmAlert.enmType.Error);
            }
            else
            {
                try
                {
                    using HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(txtpanelurl.Text);
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {txtpanelapikey.Text}");

                    HttpResponseMessage response = await httpClient.GetAsync("/api/client/account");

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        if (responseBody.StartsWith("{\"object\":\"user\","))
                        {
                            try
                            {
                                dynamic userObject = JsonConvert.DeserializeObject<dynamic>(responseBody);

                                Pterodactyl.User.Info.panel_id = userObject.attributes.id;
                                Pterodactyl.User.Info.panel_admin = userObject.attributes.admin;
                                Pterodactyl.User.Info.panel_username = userObject.attributes.username;
                                Pterodactyl.User.Info.panel_email = userObject.attributes.email;
                                Pterodactyl.User.Info.panel_first_name = userObject.attributes.first_name;
                                Pterodactyl.User.Info.panel_last_name = userObject.attributes.last_name;
                                Pterodactyl.User.Info.panel_language = userObject.attributes.language;
                                Pterodactyl.User.Info.panel_url = txtpanelurl.Text;
                                Pterodactyl.User.Info.panel_api_key = txtpanelapikey.Text;
                                try
                                {
                                    if (cbdirectlogin.Checked == false)
                                    {
                                        RegistryHandler rh = new RegistryHandler();
                                        rh.CreateAccountData(txtpanelname.Text, txtpanelurl.Text, txtpanelpwd.Text, txtpanelapikey.Text);
                                    }
                                    TelemetryHandler.Login();
                                    Program.Alert("Successfully logged in!", FrmAlert.enmType.Succes);
                                    FrmSessions x = new FrmSessions();
                                    x.Show();
                                    this.Hide();
                                }
                                catch (Exception ex)
                                {
                                    Program.Alert("Login failed", FrmAlert.enmType.Error);
                                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmLogin.cs]: \n" + ex.ToString());
                                }
                            }
                            catch (JsonException ex)
                            {
                                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmLogin.cs]: \n" + ex.ToString());
                                Program.Alert("Login Failed. JSON deserialization error.", FrmAlert.enmType.Error);
                            }
                        }
                        else
                        {
                            Program.Alert("Login Failed. Unexpected response format.", FrmAlert.enmType.Error);
                        }
                    }
                    else if ((int)response.StatusCode >= 500)
                    {
                        Program.Alert("Login Failed. Server returned an error.", FrmAlert.enmType.Error);
                        Program.logger.Log(Managers.LogType.Error, "[Forms.FrmLogin.cs]: \n" + $"Server returned an error ({(int)response.StatusCode}): {response.ReasonPhrase}");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable ||
                             response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                    {
                        Program.Alert("Login Failed. Server is protected by a verification page.", FrmAlert.enmType.Error);
                    }
                    else
                    {
                        Program.Alert("Login Failed. Server returned an error.", FrmAlert.enmType.Error);
                        Program.logger.Log(Managers.LogType.Error, $"[Forms.FrmLogin.cs]: \nLogin Failed with status code: {response.StatusCode}");

                    }
                }
                catch (HttpRequestException ex)
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmLogin.cs]: \n" + ex.ToString());
                    ProblemHandler.Error("FrmLogin", ex.ToString());
                    Program.Alert("Login Failed. Check url format", FrmAlert.enmType.Error);
                }
                catch (Exception ex)
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmLogin.cs]: \n" + ex.ToString());
                    Program.Alert("Login Failed", FrmAlert.enmType.Error);
                    ProblemHandler.Error("FrmLogin", ex.ToString());
                }
            }
        }

        
        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmAddSession_Load(object sender, EventArgs e)
        {
            if (IsDirectLogin == true)
            {
                cbdirectlogin.Checked = true;
            }
            else
            {
                cbdirectlogin.Checked = false;
            }
        }
    }
}
