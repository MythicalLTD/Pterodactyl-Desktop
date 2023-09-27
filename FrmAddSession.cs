using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PteroController
{
    public partial class FrmAddSession : Form
    {
        public FrmAddSession()
        {
            InitializeComponent();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpanelurl.Text == "" && txtpanelapikey.Text == "" && txtpanelname.Text == "")
            {
                Program.Alert("Please fill in all required information", FrmAlert.enmType.Error);
            }
            else
            {
                if (txtpanelpwd.Text == "")
                {
                    Program.Alert("SFTP module disabled", FrmAlert.enmType.Warning);
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
                            RegistryHandler rh = new RegistryHandler();
                            rh.CreateAccountData(txtpanelname.Text, txtpanelurl.Text, txtpanelpwd.Text, txtpanelapikey.Text);
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
                        // Handle any exceptions that may occur during the API call
                        Program.Alert($"An error occurred: {ex.Message}", FrmAlert.enmType.Error);
                    }
                }
            }
        }

    }
}
