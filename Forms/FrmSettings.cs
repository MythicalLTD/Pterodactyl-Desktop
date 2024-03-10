using Pterodactyl.Handlers;
using Pterodactyl.Managers;
using Salaros.Configuration;
using Salaros.Configuration.Logging;
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
        private UIStyler styler;

        public FrmSettings(bool session)
        {
            InitializeComponent();
            this.hasSession = session;
            try
            {
                styler = new UIStyler();
                styler.LoadFromYaml("styles.yaml");
                styler.ApplyStyles(this);
            }
            catch (Exception ex)
            {
                Program.logger.Log(LogType.Error, "[UI] Failed to apply UI modification: \n" + ex.ToString());
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
            if (RegistryHandler.GetSetting("NoMinecraftServerIcon") == "true")
            {
                cbnoicon.Checked = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsavesettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbnoicon.Checked == true)
                {
                    RegistryHandler.SetSetting("NoMinecraftServerIcon", "true");
                }
                else
                {
                    RegistryHandler.SetSetting("NoMinecraftServerIcon", "false");
                }
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
                Program.Alert("Settings saved!", FrmAlert.enmType.Succes);
            }
            catch (Exception ex)
            {
                Program.Alert("Failed to save the settings!", FrmAlert.enmType.Warning);
                Program.logger.Log(Managers.LogType.Error, "[FrmSettings] Failed to save settings:\n" + ex.ToString());
            }

        }
    }
}
