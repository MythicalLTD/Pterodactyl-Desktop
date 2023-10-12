using Newtonsoft.Json;
using Pterodactyl.Handlers;
using Pterodactyl.Pterodactyl;
using System.Net.Http.Headers;
#pragma warning disable
namespace Pterodactyl.Forms
{
    public partial class FrmSessions : Form
    {
        private RegistryHandler registryHandler;
        private bool isFirstLoad = true;

        public FrmSessions()
        {
            InitializeComponent();
            registryHandler = new RegistryHandler();
            SessionListBox.SelectedIndex = -1;
            PopulateListBoxWithSessions();
        }
        private void PopulateListBoxWithSessions()
        {
            SessionListBox.Items.Clear();

            var sessionNames = registryHandler.ListSessions();

            foreach (string sessionName in sessionNames)
            {
                SessionListBox.Items.Add(sessionName);
            }
        }
        private void FrmSessions_Load(object sender, EventArgs e)
        {
            if (RegistryHandler.GetSetting("AlwaysOnTop") == "true")
            {
                this.TopMost = true;
            }
            DiscordRPCHandler discordRPC = new DiscordRPCHandler();
            discordRPC.InitializeRPC();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SessionListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private async void SessionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isFirstLoad)
                {
                    isFirstLoad = false;
                    return;
                }
                else
                {
                    if (SessionListBox.SelectedIndex >= 0)
                    {
                        string selectedItemText = SessionListBox.SelectedItem.ToString();
                        string selectedSessionName = selectedItemText.Substring(0, selectedItemText.IndexOf(" ("));
                        string selectedPanelUrl = selectedItemText.Substring(selectedItemText.IndexOf("(") + 1, selectedItemText.IndexOf(")") - selectedItemText.IndexOf("(") - 1);
                        SessionInfo sessionInfo = registryHandler.GetSessionInfo(selectedSessionName);
                        if (sessionInfo != null)
                        {
                            try
                            {
                                using HttpClient httpClient = new HttpClient();
                                httpClient.BaseAddress = new Uri(sessionInfo.PanelUrl);
                                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {sessionInfo.ApiKey}");

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
                                            Pterodactyl.User.Info.panel_url = sessionInfo.PanelUrl;
                                            Pterodactyl.User.Info.panel_api_key = sessionInfo.ApiKey;
                                            Pterodactyl.User.Info.panel_password = sessionInfo.PanelPwd;
                                            try
                                            {
                                                Program.Alert("Successfully logged in!", FrmAlert.enmType.Succes);
                                                FrmServerSelector x = new FrmServerSelector();
                                                x.Show();
                                                this.Hide();
                                            }
                                            catch (Exception ex)
                                            {
                                                Program.Alert("Login failed", FrmAlert.enmType.Error);
                                                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmSessions.cs]: \n" + ex.ToString());
                                            }
                                        }
                                        catch (JsonException ex)
                                        {
                                            Program.logger.Log(Managers.LogType.Error, "[Forms.FrmSessions.cs]: \n" + ex.ToString());
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
                                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmSessions.cs]: \n" + $"Server returned an error ({(int)response.StatusCode}): {response.ReasonPhrase}");
                                }
                                else if (response.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable ||
                                         response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                                {
                                    Program.Alert("Login Failed. Server is protected by a verification page.", FrmAlert.enmType.Error);
                                }
                                else
                                {
                                    Program.Alert("Login Failed. Server returned an error.", FrmAlert.enmType.Error);
                                    Program.logger.Log(Managers.LogType.Error, $"[Forms.FrmSessions.cs]: \nLogin Failed with status code: {response.StatusCode}");

                                }
                            }
                            catch (HttpRequestException ex)
                            {
                                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmSessions.cs]: \n" + ex.ToString());
                                Program.Alert("Login Failed. Check url format", FrmAlert.enmType.Error);
                            }
                            catch (Exception ex)
                            {
                                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmSessions.cs]: \n" + ex.ToString());
                                Program.Alert("Login Failed", FrmAlert.enmType.Error);
                            }
                        }
                        else
                        {
                            Program.Alert("Session information not found.", FrmAlert.enmType.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmSessions.cs]: \n" + ex.ToString());
                Program.Alert("We are sorry but we can't load the sessions.", FrmAlert.enmType.Error);
                ProblemHandler.Error("FrmSessions", ex.ToString());
            }
        }

        private void btnaddsession_Click(object sender, EventArgs e)
        {
            FrmLogin x = new FrmLogin(DirectLogin: false);
            x.Show();
            this.Hide();
        }

        private void btnsession_Click(object sender, EventArgs e)
        {
            FrmLogin x = new FrmLogin(DirectLogin: true);
            x.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            FrmSettings x = new FrmSettings(session: false);
            x.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {

        }
    }
}
