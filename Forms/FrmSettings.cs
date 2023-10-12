using Pterodactyl.Handlers;
using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pterodactyl.Forms
{
    public partial class FrmSettings : Form
    {
        public bool hasSession;
        public FrmSettings(bool session)
        {
            InitializeComponent();
            this.hasSession = session;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            if (hasSession == true)
            {
                FrmServerSelector x = new FrmServerSelector();
                x.Show();
                this.Hide();
            }
            else
            {
                FrmSessions x = new FrmSessions();
                x.Show();
                this.Hide();
            }
        }

        private void btnsvlist_Click(object sender, EventArgs e)
        {
            FrmServerSelector x = new FrmServerSelector();
            x.Show();
            this.Hide();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            lblappversion.Text = "Version: " + Program.AppVersion;
            lblbranch.Text = "Branch: v2develop";
            if (hasSession == true)
            {
                btnsvlist.Enabled = true;
                btnprofile.Enabled = true;
            }
            else
            {
                btnsvlist.Enabled = false;
                btnprofile.Enabled = false;
            }
            if (RegistryHandler.GetSetting("AlwaysOnTop") == "true")
            {
                cbalwaysontop.Checked = true;
                this.TopMost = true;
            }
            if (RegistryHandler.GetSetting("DisableUnstableMode") == "true")
            {
                cbdisableunstablemode.Checked = true;
            }
            if (RegistryHandler.GetSetting("DisableTelemetry") == "true")
            {
                cbdisabletlmtry.Checked = true;
            }
            if (RegistryHandler.GetSetting("DisableErrorReporting") == "true")
            {
                cberrorreport.Checked = true;
            }
            if (RegistryHandler.GetSetting("DisableDiscordRPC") == "true")
            {
                disablerpc.Checked = true;
            }
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsavesettings_Click(object sender, EventArgs e)
        {
            if (cbalwaysontop.Checked == true)
            {
                RegistryHandler.SetSetting("AlwaysOnTop", "true");
            }
            else
            {
                RegistryHandler.SetSetting("AlwaysOnTop", "false");
            }
            if (cbdisableunstablemode.Checked == false)
            {
                RegistryHandler.SetSetting("DisableUnstableMode", "false");
            }
            else
            {
                RegistryHandler.SetSetting("DisableUnstableMode", "true");
            }
            if (cbdisabletlmtry.Checked == true)
            {
                RegistryHandler.SetSetting("DisableTelemetry", "true");
            }
            else
            {
                RegistryHandler.SetSetting("DisableTelemetry", "false");
            }
            if (cberrorreport.Checked == true)
            {
                RegistryHandler.SetSetting("DisableErrorReporting", "true");
            }
            else
            {
                RegistryHandler.SetSetting("DisableErrorReporting", "false");
            }
            if (disablerpc.Checked == true)
            {
                RegistryHandler.SetSetting("DisableDiscordRPC", "true");
            }
            else
            {
                RegistryHandler.SetSetting("DisableDiscordRPC", "false");
            }
        }
    }
}
