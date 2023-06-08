using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PteroController
{
    public partial class FrmLoading : Form
    {
        public DiscordRpcClient client;

        public FrmLoading()
        {
            InitializeComponent();
            InitializeRPC();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            PteroControllerWebServer.StopServer();
            Application.Exit();
        }
        private async void CheckForUpdate()
        {
            string url = "https://raw.githubusercontent.com/MythicalLTD/PteroController/develop/Properties/AssemblyInfo.cs";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string assemblyInfoContent = await httpClient.GetStringAsync(url);
                    string versionPattern = @"AssemblyFileVersion\(""(.*?)""\)";
                    Match match = Regex.Match(assemblyInfoContent, versionPattern);
                    if (match.Success)
                    {
                        string versionValue = match.Groups[1].Value;
                        if (versionValue != Application.ProductVersion)
                        {
                            DialogResult result = MessageBox.Show("A new update is available. Do you want to install it?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                FrmInstall x = new FrmInstall();
                                x.Show();

                                this.Hide();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            tm.Enabled = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("[{0:HH:mm:ss}] Version not found in AssemblyInfo.cs", DateTime.Now);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[{0:HH:mm:ss}] Error: " + ex.Message, DateTime.Now);
                }
            }
        }
        private void FrmLoading_Load(object sender, EventArgs e)
        {
            CheckForUpdate();
        }

        void InitializeRPC()
        {
            try
            {
                client = new DiscordRpcClient("1114229771426078790");
                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                client.OnReady += (sender, e) =>
                {
                };
                client.OnPresenceUpdate += (sender, e) =>
                {
                };
                client.Initialize();

                DiscordRPC.Button btns = new DiscordRPC.Button();
                DiscordRPC.Button btns2 = new DiscordRPC.Button();
                btns.Label = "Pterodactyl";
                btns.Url = "https://pterodactyl.io";
                btns2.Label = "Desktop app";
                btns2.Url = "https://github.com/MythicalLTD/PteroController";

                client.SetPresence(new RichPresence()
                {
                    Details = "Using PteroController",
                    State = "A Pterodactyl Panel Desktop App! <3",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "PteroController",
                    },
                    Buttons = new DiscordRPC.Button[]
                    {
                    btns,
                    btns2
                    },
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] Faild to load discord rpc: " + ex.Message, DateTime.Now);
            }

        }

        private void tm_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 580)
            {
                tm.Stop();
                FrmLogin x = new FrmLogin();
                x.Show();
                this.Hide();
            }
        }
    }
}
