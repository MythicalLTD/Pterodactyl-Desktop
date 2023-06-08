using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace PteroController
{
    public partial class FrmInstall : Form
    {
        string appPath = Application.StartupPath + "\\PteroController.bat";

        public FrmInstall()
        {
            InitializeComponent();
        }

        private void FrmInstall_Load(object sender, EventArgs e)
        {
            DownloadAndRunScript();
        }

        private void DownloadAndRunScript()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/MythicalLTD/PteroController/develop/PteroController.bat"), appPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (INSTALL) An error occurred: " + ex.Message, DateTime.Now);
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            guna2ProgressBar1.Value = e.ProgressPercentage;
            label2.Text = "Downloading...   " + BytesToString(e.BytesReceived) + " / " + BytesToString(e.TotalBytesToReceive);
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            label2.Text = "Done!";
            DialogResult dr = MessageBox.Show("Do you want to run PteroController?", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(appPath);
                    Application.Exit();
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (INSTALL) An error occurred: " + ex.Message, DateTime.Now);
            }
        }

        private static string BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(bytes) * num).ToString() + suf[place];
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            PteroControllerWebServer.StopServer();
            Application.Exit();
        }
    }
}
