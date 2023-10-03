using Guna.UI2.WinForms;
using Newtonsoft.Json;
using PteroController.PteroConsoleHook;
using System.Net;

namespace PteroController.Forms
{
    public partial class FrmServerController : Form
    {
        private string? serverIdentifier;
        public FrmServerController(string serverIdentifier)
        {
            InitializeComponent();
            this.serverIdentifier = serverIdentifier;

        }
        private async void initPteroConsole()
        {
            try
            {
                var console = new PteroConsole.NET.PteroConsole();
                console.OnServerResourceUpdated += (sender, resource) =>
                {
                    Console.WriteLine($"Stats: {resource.Uptime}, State: {resource.State}");
                    //cpu.Value = resource.State;
                };
                console.RequestToken += pteroConsole =>
                {
                    Console.WriteLine("Revoking token");
                    var wc = new WebClient();
                    wc.Headers.Add("Authorization", "Bearer " + Pterodactyl.User.Info.panel_api_key);
                    var raw = wc.DownloadString($"{Pterodactyl.User.Info.panel_url}/api/client/servers/{serverIdentifier}/websocket");
                    var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;
                    return data.Token;
                };
                var wc = new WebClient();
                wc.Headers.Add("Authorization", "Bearer " + Pterodactyl.User.Info.panel_api_key);
                var raw = wc.DownloadString($"{Pterodactyl.User.Info.panel_url}/api/client/servers/{serverIdentifier}/websocket");
                var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;
                await console.Connect(Pterodactyl.User.Info.panel_url, data.Socket, data.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Program.Alert("We are sorry but we can't launch the stats", FrmAlert.enmType.Warning);
            }
        }
        private void FrmServerController_Load(object sender, EventArgs e)
        {
            initPteroConsole();
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