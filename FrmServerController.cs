namespace PteroController
{
    public partial class FrmServerController : Form
    {
        private string serverIdentifier;

        public FrmServerController(string serverIdentifier)
        {
            InitializeComponent();
            this.serverIdentifier = serverIdentifier;
        }

        private void FrmServerController_Load(object sender, EventArgs e)
        {
            if (FrmLoader.unstableMode == true)
            {
                lblappname.Text = $"PteroController ({Program.AppVersion} DEV)";
            }
            else
            {
                lblappname.Text = $"PteroController ({Program.AppVersion})";

            }
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FrmSessions x = new FrmSessions();
            x.Show();
            this.Hide();
        }

        private void btnservers_Click(object sender, EventArgs e)
        {
            FrmServerSelector x = new FrmServerSelector();
            x.Show();
            this.Hide();
        }
    }

}