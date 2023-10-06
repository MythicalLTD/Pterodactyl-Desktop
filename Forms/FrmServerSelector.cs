using Newtonsoft.Json;
using System.Net.Http;

namespace Pterodactyl.Forms;

public partial class FrmServerSelector : Form
{
    private HttpClient httpClient;

    public FrmServerSelector()
    {
        InitializeComponent();
        serverListBox.SelectedIndex = -1;
        httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
    }
    private bool isFirstLoad = true;

    private async void FrmServerSelector_Load(object sender, EventArgs e)
    {
        lblwlc.Text = "Welcome, " + Pterodactyl.User.Info.panel_username;
        try
        {
#pragma warning disable
            HttpResponseMessage response = await httpClient.GetAsync(Pterodactyl.User.Info.panel_url + "/api/client");
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            PterodactylApiResponse apiResponse = JsonConvert.DeserializeObject<PterodactylApiResponse>(jsonResponse);
            List<ServerData> serverDataList = apiResponse.Data;
            List<string> serverNames = new List<string>();
            foreach (var serverData in serverDataList)
            {
                string serverName = $"{serverData.Attributes.Name} ({serverData.Attributes.Identifier})";
                serverNames.Add(serverName);
            }
            serverListBox.DataSource = serverNames;
            serverListBox.ClearSelected();
            isFirstLoad = true;
#pragma warning restore
        }
        catch (Exception ex)
        {
            Console.WriteLine("[{0:HH:mm:ss}] (SERVER LIST) An error occurred: " + ex.Message + "", DateTime.Now);
        }
    }

    private void serverListBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
    public class ServerData
    {
        public ServerAttributes? Attributes { get; set; }
    }

    public class ServerAttributes
    {
        public string? Identifier { get; set; }
        public string? Name { get; set; }
    }
    public class PterodactylApiResponse
    {
        public List<ServerData>? Data { get; set; }
    }
    private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (isFirstLoad)
            {
                isFirstLoad = false;
                return;
            }

            if (serverListBox.SelectedItem != null && serverListBox.SelectedItem is string selectedServerName)
            {
                string identifier = selectedServerName.Substring(selectedServerName.IndexOf('(') + 1);
                identifier = identifier.TrimEnd(')');
                FrmServerController serverDetailsForm = new FrmServerController(identifier);
                serverDetailsForm.Show();
                this.Hide();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("We are sorry but we can't load the servers:\n" + ex.Message);
        }
    }

    private void lblwlc_Click(object sender, EventArgs e)
    {

    }

    private void lblexit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void lblminimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void btnlogout_Click(object sender, EventArgs e)
    {
        FrmSessions x = new FrmSessions();
        x.Show();
        this.Hide();
    }

    private void pbavatar_Click(object sender, EventArgs e)
    {

    }

    private void btnhome_Click(object sender, EventArgs e)
    {

    }

    private void btnsettings_Click(object sender, EventArgs e)
    {
        FrmSettings x = new FrmSettings(session: true);
        x.Show();
        this.Hide();
    }

    private void btnsvlist_Click(object sender, EventArgs e)
    {

    }

    private void btnprofile_Click(object sender, EventArgs e)
    {

    }

    private void btnexit_Click(object sender, EventArgs e)
    {
        Pterodactyl.User.Info.panel_id = null;
        Pterodactyl.User.Info.panel_admin = null;
        Pterodactyl.User.Info.panel_username = null;
        Pterodactyl.User.Info.panel_email = null;
        Pterodactyl.User.Info.panel_first_name = null;
        Pterodactyl.User.Info.panel_last_name = null;
        Pterodactyl.User.Info.panel_language = null;
        Pterodactyl.User.Info.panel_url = null;
        Pterodactyl.User.Info.panel_api_key = null;
        FrmSessions x = new FrmSessions();
        x.Show();
        this.Hide();
    }

    private void lblwlcdsc_Click(object sender, EventArgs e)
    {

    }
}
