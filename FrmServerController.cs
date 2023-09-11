namespace PteroController;

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

    }
}
