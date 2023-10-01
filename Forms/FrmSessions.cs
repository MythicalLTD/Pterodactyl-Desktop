using PteroController.Handlers;
using PteroController.Pterodactyl;
#pragma warning disable
namespace PteroController.Forms
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
            RPCHandler discordRPC = new RPCHandler();
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

                            await Pterodactyl.User.Info.Get(sessionInfo.PanelUrl, sessionInfo.ApiKey, sessionInfo.PanelPwd);
                            if (Pterodactyl.User.Info.panel_username != null &&
                                Pterodactyl.User.Info.panel_email != null &&
                                Pterodactyl.User.Info.panel_id != null)
                            {
                                SessionListBox.Enabled = false;
                                FrmServerSelector x = new FrmServerSelector();
                                x.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Session information not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We are sorry but we can't load the sessions:\n" + ex.Message);
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
    }
}
