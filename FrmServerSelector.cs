using Newtonsoft.Json;

namespace PteroController;

public partial class FrmServerSelector : Form
{
    private HttpClient httpClient;

    public FrmServerSelector()
    {
        InitializeComponent();
        serverListBox.SelectedIndex = -1;
        httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {FrmLogin.panel_api_key}");
    }
    private bool isFirstLoad = true;

    private async void FrmServerSelector_Load(object sender, EventArgs e)
    {
        lblwlc.Text = "Welcome, " + FrmLogin.panel_username;
        try
        {

            HttpResponseMessage response = await httpClient.GetAsync(FrmLogin.panel_url + "/api/client");
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
}
