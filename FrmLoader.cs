using System.Diagnostics;

namespace PteroController
{
    public partial class FrmLoader : Form
    {
        public static bool unstableMode;
        public FrmLoader()
        {
            InitializeComponent();
        }

        private void FrmLoader_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncnt_Click(object sender, EventArgs e)
        {
            if (cbunstblmode.Checked == true)
            {
                MessageBox.Show("Unstable mode is turned on. Make sure you don't complain about problems. This is an unstable mode, and those extra features are still in development and are not finished. If you find a bug, open an issue on our GitHub.", "PteroController", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unstableMode = true;
            }
            FrmSessions x = new FrmSessions();
            x.Show();
            this.Hide();
        }

        private void btngithub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/mythicalltd/pterocontroller") { UseShellExecute = true });

        }
    }
}
