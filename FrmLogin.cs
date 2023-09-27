using Salaros.Configuration;

namespace PteroController
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            RPC discordRPC = new RPC();
            discordRPC.InitializeRPC();
        }

        private void CheckSession()
        {
            try
            {
                var account = new ConfigParser(Program.AppAccountInfo);
                var EpanelUrl = account.GetValue("LOGIN", "panel_url");
                var EpanelApi = account.GetValue("LOGIN", "api_key");
                var EpanelPass = account.GetValue("LOGIN", "panel_pwd");
                if (EpanelApi == null || EpanelPass == null || EpanelApi == null)
                {

                }
                else
                {
                    string panelUrl = Base64Encryption.Decrypt(EpanelUrl);
                    string panelAPI = Base64Encryption.Decrypt(EpanelApi);
                    string panelPass = Base64Encryption.Decrypt(EpanelPass);
                    txtpanelurl.Text = panelUrl;
                    txtpanelapikey.Text = panelAPI;
                    txtpanelpwd.Text = panelPass;
                    btnlogin.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Session Error: " + ex.Message);
                Program.Alert("Failed to get session", FrmAlert.enmType.Error);
            }
        }

        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpanelurl.Text == "" && txtpanelapikey.Text == "")
            {

                Program.Alert("Please fill in all required information", FrmAlert.enmType.Error);
            }
            else
            {
                if (txtpanelpwd.Text == "")
                {
                    Program.Alert("SFTP module disabled", FrmAlert.enmType.Warning);
                }
#pragma warning disable
                Pterodactyl.User.Info.Get(txtpanelurl.Text, txtpanelapikey.Text, txtpanelpwd.Text);
                if (Pterodactyl.User.Info.panel_username != null && Pterodactyl.User.Info.panel_email!= null && Pterodactyl.User.Info.panel_id!= null)
                {
                    FrmServerSelector x = new FrmServerSelector();
                    x.Show();
                    this.Hide();
                }
                else
                {
                    Program.Alert("Failed to login", FrmAlert.enmType.Error);
                }
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CheckSession();
        }
    }
}