
using PteroController.Properties;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PteroController.Forms
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void CheckForUpdate()
        {
            string url = "https://raw.githubusercontent.com/MythicalLTD/PteroController/v2develop/Program.cs";

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
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[{0:HH:mm:ss}] Error: " + ex.Message, DateTime.Now);
                }
            }
        }
        private void RunInstallerWithBatchScript()
        {
            if (File.Exists("PteroControllerSetup.msi"))
            {
                string batchScript = @"
        @echo off
        start /b PteroControllerSetup.msi
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
        private void FrmLoading_Load(object sender, EventArgs e)
        {
            CheckForUpdate();
        }
        public static async Task Download()
        {
            string releaseURL = "https://github.com/MythicalLTD/PteroController/releases/latest/download/PteroControllerSetup.msi";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(releaseURL);

                if (response.IsSuccessStatusCode)
                {
                    using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                    {
                        using (FileStream fileStream = new FileStream("PteroControllerSetup.msi", FileMode.Create))
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
    }
}
