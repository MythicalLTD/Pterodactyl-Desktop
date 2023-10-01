namespace PteroController
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
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
                await Pterodactyl.User.Info.Get(txtpanelurl.Text, txtpanelapikey.Text, txtpanelpwd.Text);
                if (Pterodactyl.User.Info.panel_username != null &&
                    Pterodactyl.User.Info.panel_email != null &&
                    Pterodactyl.User.Info.panel_id != null)
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

        }
    }
}