using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pterodactyl.PteroConsoleHook;
using RestSharp;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace Pterodactyl.Forms
{
    public partial class FrmServerController : Form
    {
        private string? serverIdentifier;
        public static string? sftp_ip;
        public static string? sftp_port;
        public static string? ipAlias;
        public static string? sv_disktotal;
        public static string? svmport;
        private DataTable datatable;
        private HttpClient httpClient;

        public FrmServerController(string serverIdentifier)
        {
            InitializeComponent();
            this.serverIdentifier = serverIdentifier;
            httpClient = new HttpClient();
            datatable = new DataTable();
            AddColumnsToDataTable();
            dataTable.DataSource = datatable;
        }
        private JObject ExtractJsonFromHtml(string html)
        {
            var startIndex = html.IndexOf('{');
            var endIndex = html.LastIndexOf('}');

            if (startIndex != -1 && endIndex != -1)
            {
                var jsonData = html.Substring(startIndex, endIndex - startIndex + 1);
                return JObject.Parse(jsonData);
            }

            return null;
        }
        private async Task LoadDatabases()
        {
            try
            {
                var apiUrl = $"{Pterodactyl.User.Info.panel_url}/api/client/servers/{serverIdentifier}/databases?include=password";

                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");

                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonData = ExtractJsonFromHtml(content);

                    if (jsonData != null && jsonData.ContainsKey("data"))
                    {
                        var data = jsonData["data"];

                        datatable.Columns.Clear();
                        datatable.Rows.Clear();
                        datatable.Columns.Add("DB Name", typeof(string));
                        datatable.Columns.Add("DB Username", typeof(string));
                        datatable.Columns.Add("DB Password", typeof(string));
                        datatable.Columns.Add("DB Address", typeof(string));
                        datatable.Columns.Add("DB Port", typeof(int));
                        datatable.Columns.Add("Allowed IP'S", typeof(string));

                        foreach (var database in data)
                        {
                            var attributes = database["attributes"];
                            var passwordAttributes = attributes["relationships"]["password"]["attributes"];
                            string id = attributes["connections_from"]?.ToString();
                            string name = attributes["name"]?.ToString();
                            string username = attributes["username"]?.ToString();
                            string password = passwordAttributes["password"]?.ToString();
                            string hostAddress = attributes["host"]?["address"]?.ToString();
                            int hostPort = attributes["host"]?["port"]?.Value<int>() ?? 0;

                            datatable.Rows.Add(name, username, password, hostAddress, hostPort, id);
                        }
                    }
                    else
                    {
                        Program.Alert("Failed to parse JSON from response.", FrmAlert.enmType.Warning);
                    }
                }
                else
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + errorResponse);
                    Program.Alert("Sowy we can't get your database list", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
                Program.Alert("Sowy we can't get your database list", FrmAlert.enmType.Warning);
            }
        }
        private void AddColumnsToDataTable()
        {
            datatable.Columns.Add("ID", typeof(string));
            datatable.Columns.Add("Name", typeof(string));
            datatable.Columns.Add("Username", typeof(string));
            datatable.Columns.Add("Host Address", typeof(string));
            datatable.Columns.Add("Host Port", typeof(int));
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
                    try
                    {
                        lblsvstatus.Invoke((Action)(() => lblsvstatus.Text = $"Uptime: {resource.State} ({formattedUptime})"));
                        lblsvram.Invoke((Action)(() => lblsvram.Text = $"Memory: {(resource.MemoryBytes / (1024 * 1024))} MB / {(resource.MemoryLimitBytes / (1024 * 1024))} MB"));
                        lblsvcpu.Invoke((Action)(() => lblsvcpu.Text = $"Processor: {resource.CpuAbsolute} / 100%"));
                        lblsvdisk.Invoke((Action)(() => lblsvdisk.Text = $"Disk: {resource.DiskBytes / (1024 * 1024)} MB / {sv_disktotal} MB"));
                        statscpu.Invoke((Action)(() => statscpu.Value = (int)(resource.CpuAbsolute)));
                        statsram.Invoke((Action)(() => statsram.Value = (int)((resource.MemoryBytes / (double)resource.MemoryLimitBytes) * 100)));
                    }
                    catch (Exception ex)
                    {
                        Program.Alert("Failed to update server status", FrmAlert.enmType.Warning);
                        Program.logger.Log(Managers.LogType.Error, "[User.Login.cs]: \n" + ex.Message);
                    }
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
        private async void FrmServerController_Load(object sender, EventArgs e)
        {
            getServerInfo();
            initPteroConsole();
            isMinecraftServer();
            await LoadDatabases();
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
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
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
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
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
                    sv_disktotal = serverMaxDisk;
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
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
                Program.Alert("Failed to get the server info", FrmAlert.enmType.Warning);
            }
        }

        private void pbstart_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.POST);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"start\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server is starting", FrmAlert.enmType.Succes);
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to start the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
                Program.Alert("Failed to start the server", FrmAlert.enmType.Warning);
            }
        }

        private void pbstop_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.POST);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"stop\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server is stopping", FrmAlert.enmType.Succes);
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to stop the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
                Program.Alert("Failed to stop the server", FrmAlert.enmType.Warning);
            }
        }

        private void pbrestart_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.POST);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"restart\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server is restarting", FrmAlert.enmType.Succes);
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to restart the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
                Program.Alert("Failed to start the server", FrmAlert.enmType.Warning);
            }
        }

        private void pbkill_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.POST);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"kill\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server killed", FrmAlert.enmType.Succes);
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to kill the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
                Program.Alert("Failed to kill the server", FrmAlert.enmType.Warning);
            }
        }

        private void btnstartconsole_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\PteroConsole.exe"))
                {
                    string executablePath = "PteroConsole.exe";
                    string arguments = $"--panel-url {Pterodactyl.User.Info.panel_url} --panel-apikey {Pterodactyl.User.Info.panel_api_key} --serveruuid {serverIdentifier}";

                    Process process = new Process();
                    process.StartInfo.FileName = executablePath;
                    process.StartInfo.Arguments = arguments;
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.CreateNoWindow = false;
                    process.Start();
                }
                else
                {
                    Program.Alert("PteroConsole is missing please reinstall", FrmAlert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                Program.Alert("Failed to start console", FrmAlert.enmType.Error);
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.Message);
            }
        }

        private void btnserverlist_Click(object sender, EventArgs e)
        {
            FrmServerSelector x = new FrmServerSelector();
            x.Show();
            this.Hide();
        }

        private void btndbs_Click(object sender, EventArgs e)
        {
            Pages.SelectedTab = PageDatabases;
        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrEmpty(cellValue))
                {
                    Clipboard.SetText(cellValue);
                }
            }
        }
    }
}