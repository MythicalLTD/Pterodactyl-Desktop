using System.IO;
using System.IO.Compression;
using System.Net.Http;

namespace PteroController.Forms
{
    public partial class FrmInstallTools : Form
    {
        public FrmInstallTools()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but if you don't download the addons we can't start the app", "Addons", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private async void btnaccpetinstall_Click(object sender, EventArgs e)
        {
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
                Console.WriteLine("Error during deleting: " + ex.Message);

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
                    Console.WriteLine("Addons have been extracted successfully!");
                }
                else
                {
                    Console.WriteLine("Client.zip not found for extraction.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during unzip: " + ex.Message);
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
                            Console.WriteLine("Addons have been downloaded successfully!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Failed to download Addons: {0}", response.StatusCode);
                    MessageBox.Show("Failed to download update \nTry again later");
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
    }
}
