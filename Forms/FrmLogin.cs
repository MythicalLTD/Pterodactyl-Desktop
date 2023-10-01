using PteroController.Handlers;

namespace PteroController.Forms
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
                    await Pterodactyl.User.Info.Get(txtpanelurl.Text, txtpanelapikey.Text, txtpanelpwd.Text);
                    if (Pterodactyl.User.Info.panel_username != null &&
                        Pterodactyl.User.Info.panel_email != null &&
                        Pterodactyl.User.Info.panel_id != null)
                    {
                        if (cbdirectlogin.Checked == false)
                        {
                            RegistryHandler rh = new RegistryHandler();
                            rh.CreateAccountData(txtpanelname.Text, txtpanelurl.Text, txtpanelpwd.Text, txtpanelapikey.Text);
                        }
                        FrmSessions x = new FrmSessions();
                        x.Show();
                        this.Hide();
                    }
                    else
                    {
                        Program.Alert("Failed to login", FrmAlert.enmType.Error);
                    }
                }
                catch (Exception ex)
                {
                    Program.Alert($"An error occurred: {ex.Message}", FrmAlert.enmType.Error);
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
