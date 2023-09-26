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
            ConsoleManager.ConsoleManager.CheckInstall();

        }

        private void updateAppTitle()
        {

        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}