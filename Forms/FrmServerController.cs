using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pterodactyl.PteroConsoleHook;
using RestSharp;
using System.Diagnostics;
using System.Net;
namespace Pterodactyl.Forms
{
    public partial class FrmServerController : Form
    {
        private string? serverIdentifier;
        public static string? sftp_ip;
        public static string? sftp_port;
        public static string? ipAlias;
        public static string? svmport;
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
                    long uptimeInMilliseconds = (long)(resource.Uptime);
                    TimeSpan uptime = TimeSpan.FromMilliseconds(uptimeInMilliseconds);
                    string formattedUptime = $"{uptime.Days}D {uptime.Hours}H {uptime.Minutes}M {uptime.Seconds}S";
                    Console.WriteLine(formattedUptime);
                    statscpu.Value = (int)(resource.CpuAbsolute);
                    statsram.Value = (int)((resource.MemoryBytes / (double)resource.MemoryLimitBytes) * 100);
                    lblsvstatus.Text = $"Status: {resource.State}";
                    
                };
                console.RequestToken += pteroConsole =>
                {
                    Console.WriteLine("Revoking token");
                    WebClient wc = new WebClient();
                    wc.Headers.Add("Authorization", "Bearer " + Pterodactyl.User.Info.panel_api_key);
                    var raw = wc.DownloadString($"{Pterodactyl.User.Info.panel_url}/api/client/servers/{serverIdentifier}/websocket");
                    var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;
                    return data.Token;
                };
                WebClient wc = new WebClient();
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
            getServerInfo();
            isMinecraftServer();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Pages.SelectedTab = PageHome;
        }


        private void btnfilemanager_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\WinSCP.exe"))
                {
                    string command = Application.StartupPath + @"\WinSCP.exe";
                    string arguments = @"sftp://" + Pterodactyl.User.Info.panel_username + "." + serverIdentifier + ":" + Pterodactyl.User.Info.panel_password + "@" + sftp_ip + ":" + sftp_port + "";
                    ProcessStartInfo processInfo = new ProcessStartInfo(command, arguments);
                    processInfo.RedirectStandardOutput = true;
                    processInfo.UseShellExecute = false;

                    Process process = Process.Start(processInfo);
                }
                else
                {
                    Program.Alert("WinSCP missing please reinstall", FrmAlert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                Program.Alert("WinSCP failed to start", FrmAlert.enmType.Error);
                Program.logger.Log(Managers.LogType.Error, "[Pterodactyl.Forms.FrmServerController.cs]: \n" + ex.Message);
            }
        }
        private void isMinecraftServer()
        {
            try
            {
                string url = "https://api.mcsrvstat.us/2/" + ipAlias + ":" + svmport;
                string json = new WebClient().DownloadString(url);
                JObject data = JObject.Parse(json);
                bool isOnline = (bool)data["online"];
                if (isOnline)
                {
                    string imageDataUri = (string)data["icon"];
                    if (imageDataUri != null)
                    {
                        string base64Data = imageDataUri.Split(',')[1];
                        byte[] imageData = Convert.FromBase64String(base64Data);
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(ms);
                            pcsvimg.Image = image;
                        }
                    }
                    else
                    {
                        Program.Alert("Failed to get the icon", FrmAlert.enmType.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                Program.Alert("Failed to check for a minecraft server", FrmAlert.enmType.Warning);
                Program.logger.Log(Managers.LogType.Error, "[Pterodactyl.Forms.FrmServerController.cs]: \n" + ex.Message);
            }
        }
        private void getServerInfo()
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}", Method.GET);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");

                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    var serverInfo = JObject.Parse(response.Content);

                    string serverName = serverInfo["attributes"]["name"].ToString();
                    string serverNode = serverInfo["attributes"]["node"].ToString();
                    string serverDescription = serverInfo["attributes"]["description"].ToString();
                    string serverMaxRam = serverInfo["attributes"]["limits"]["memory"].ToString();
                    string serverMaxDisk = serverInfo["attributes"]["limits"]["disk"].ToString();
                    string serverMaxCpu = serverInfo["attributes"]["limits"]["cpu"].ToString();
                    sftp_port = serverInfo["attributes"]["sftp_details"]["port"].ToString();
                    sftp_ip = serverInfo["attributes"]["sftp_details"]["ip"].ToString();
                    if (serverMaxRam == "0")
                    {
                        lblsvram.Text = "Memory: Unlimited";
                    }
                    if (serverMaxDisk == "0")
                    {
                        lblsvdisk.Text = "Disk: Unlimited";
                    }
                    if (serverMaxCpu == "")
                    {
                        lblsvcpu.Text = "Processor: Unlimited";
                    }
                    lblsvname.Text = "Name: " + serverName;
                    lblsvnode.Text = "Node: " + serverNode;
                    var allocations = serverInfo["attributes"]["relationships"]["allocations"]["data"];
                    foreach (var allocation in allocations)
                    {
                        if (allocation["attributes"]["is_default"].ToObject<bool>())
                        {
                            ipAlias = allocation["attributes"]["ip_alias"].ToString();
                            svmport = allocation["attributes"]["port"].ToString();
                            lblsvip.Text = "IP: " + (string.IsNullOrEmpty(ipAlias) ? "N/A" : ipAlias) + ":" + (string.IsNullOrEmpty(svmport) ? "N/A" : svmport);
                            break;
                        }
                    }
                }
                else
                {
                    Program.Alert("Failed to get the server info", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Pterodactyl.Forms.FrmServerController.cs]: \n" + ex.Message);
                Program.Alert("Failed to get the server info", FrmAlert.enmType.Warning);
            }
        }

        private void lblsvdisk_Click(object sender, EventArgs e)
        {

        }
    }
}