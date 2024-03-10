using Pterodactyl.Handlers;
using Pterodactyl.Managers;
using System.IO;
using System.IO.Compression;
using System.Net.Http;

namespace Pterodactyl.Forms
{
    public partial class FrmInstallTools : Form
    {
        private UIStyler styler;
        public FrmInstallTools()
        {
            InitializeComponent();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but if you don't download the addons we can't start the app", "Addons", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private async void btnaccpetinstall_Click(object sender, EventArgs e)
        {
            RegistryHandler.SetSetting("AlwaysOnTop", "false");
            RegistryHandler.SetSetting("DisableUnstableMode", "true");
            RegistryHandler.SetSetting("DisableTelemetry", "false");
            RegistryHandler.SetSetting("DisableErrorReporting", "false");
            RegistryHandler.SetSetting("DisableDiscordRPC", "false");
            TelemetryHandler.InstallTools();
            lbldonotclose.Visible = true;
            lblinstallinfo.Text = "Additional software installation";
            lblinstalldesc.Text = "Please wait while we download and install our core add-ons.";
            btnaccpetinstall.Enabled = false;
            btndeny.Enabled = false;
            await Addons();
            MessageBox.Show("Installation successfully!", "Addons");
            Application.Restart();
        }
        public static async Task Addons()
        {
            await Download();
            Unzip();
            Delete();
        }
        public static void Delete()
        {
            try
            {
                File.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Client.zip"));
            }
            catch (Exception ex)
            {
                ProblemHandler.Error("FrmInstallTools", ex.ToString());
                Program.logger.Log(Managers.LogType.Info, "[Forms.FrmInstallTools.cs]: \n" + ex.ToString());
            }
        }

        public static void Unzip()
        {
            try
            {
                string zipFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Client.zip");
                string extractPath = AppDomain.CurrentDomain.BaseDirectory;

                if (File.Exists(zipFilePath))
                {
                    ZipFile.ExtractToDirectory(zipFilePath, extractPath);
                    Program.logger.Log(Managers.LogType.Info, "[Forms.FrmInstallTools.cs]: \nAddons have been extracted successfully!");
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmInstallTools.cs]: \nClient.zip not found for extraction.");
                    MessageBox.Show("Client.zip not found for extraction. \nTry again later", "Addons", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                ProblemHandler.Error("FrmInstallTools", ex.ToString());
                Program.logger.Log(Managers.LogType.Info, "[Forms.FrmInstallTools.cs]: \n" + ex.ToString());
                MessageBox.Show("Client.zip faild extract. \nTry again later", "Addons", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public static async Task Download()
        {
            string releaseURL = "https://github.com/MythicalLTD/PteroAddons/releases/latest/download/Client.zip";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(releaseURL);

                if (response.IsSuccessStatusCode)
                {
                    using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                    {
                        using (FileStream fileStream = new FileStream("Client.zip", FileMode.Create))
                        {
                            await contentStream.CopyToAsync(fileStream);
                            Program.logger.Log(Managers.LogType.Info, "[Forms.FrmInstallTools.cs]: \nAddons have been downloaded successfully!");
                        }
                    }
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Info, "[Forms.FrmInstallTools.cs]: \nFailed to download Addons: " + response.StatusCode);
                    MessageBox.Show("Failed to download addons \nTry again later");
                    Application.Exit();
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

        private void FrmInstallTools_Load(object sender, EventArgs e)
        {
            if (RegistryHandler.GetSetting("AlwaysOnTop") == "true")
            {
                this.TopMost = true;
            }
        }
    }
}
