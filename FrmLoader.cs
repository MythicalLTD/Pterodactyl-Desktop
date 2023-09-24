namespace PteroController
{
    public partial class FrmLoader : Form
    {
        private Form formToOpen;
        public FrmLoader(Form formToOpen)
        {
            InitializeComponent();
            this.formToOpen = formToOpen;
        }

        private void FrmLoader_Load(object sender, EventArgs e)
        {
            this.formToOpen.Show();
            FrmLoader fl = (this);
            fl.Hide();
        }
    }
}
