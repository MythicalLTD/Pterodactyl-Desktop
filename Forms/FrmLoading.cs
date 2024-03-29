﻿
using Pterodactyl.Handlers;
using Pterodactyl.Managers;
using Pterodactyl.Properties;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Pterodactyl.Forms
{
    public partial class FrmLoading : Form
    {
        private UIStyler styler;

        public FrmLoading()
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

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void CheckForUpdate()
        {
            string url = "https://raw.githubusercontent.com/MythicalLTD/Pterodactyl-Desktop/v2develop/Program.cs";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string programContent = await httpClient.GetStringAsync(url);
                    string versionPattern = @"public static string AppVersion = ""(.*?)"";";
                    Match match = Regex.Match(programContent, versionPattern);
                    if (match.Success)
                    {
                        string versionValue = match.Groups[1].Value;
                        if (versionValue != Program.AppVersion)
                        {
                            DialogResult result = MessageBox.Show("A new update is available. Do you want to install it?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                await Download();
                                RunInstallerWithBatchScript();
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
                        Console.WriteLine("[{0:HH:mm:ss}] Version not found in Program.cs", DateTime.Now);
                        ProblemHandler.Critical("FrmLoading", "Version not found in Program.cs");
                    }
                }
                catch (Exception ex)
                {
                    ProblemHandler.Error("FrmLoading", ex.ToString());
                    Console.WriteLine("[{0:HH:mm:ss}] Error: " + ex.ToString(), DateTime.Now);
                }
            }
        }
        private void RunInstallerWithBatchScript()
        {
            try
            {
                if (File.Exists("PterodactylSetup.msi"))
                {
                    string batchScript = @"
        @echo off
        start /b PterodactylSetup.msi
        exit
    ";

                    string batchFilePath = Path.Combine(Environment.CurrentDirectory, "InstallInBackground.bat");

                    File.WriteAllText(batchFilePath, batchScript);

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = batchFilePath,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    });

                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Can't find the installer please try again");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't find the installer please try again");
                ProblemHandler.Error("FrmLoading", ex.ToString());
                Application.Exit();
            }

        }
        private void FrmLoading_Load(object sender, EventArgs e)
        {
            CheckForUpdate();
            if (RegistryHandler.GetSetting("AlwaysOnTop") == "true")
            {
                this.TopMost = true;
            }
        }

        public static async Task Download()
        {
            string releaseURL = "https://github.com/MythicalLTD/Pterodactyl-Desktop/releases/latest/download/PterodactylSetup.msi";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(releaseURL);

                if (response.IsSuccessStatusCode)
                {
                    using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                    {
                        using (FileStream fileStream = new FileStream("PterodactylSetup.msi", FileMode.Create))
                        {
                            await contentStream.CopyToAsync(fileStream);
                            Console.WriteLine("Updater has been downloaded successfully!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Failed to download updater: {0}", response.StatusCode);
                    MessageBox.Show("Failed to download the updater \nTry again later");
                    Application.Exit();
                }
            }
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 580)
            {
                tm.Stop();
                FrmSessions x = new FrmSessions();
                x.Show();
                this.Hide();
            }
        }

        private void lblappname_Click(object sender, EventArgs e)
        {

        }

        private void appicon_Click(object sender, EventArgs e)
        {

        }
    }
}
