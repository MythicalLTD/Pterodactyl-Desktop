using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PteroController
{
    public partial class FrmServerControler : Form
    {
        public static string ServerId;
        public static string authToken;
        public static string wsuri;
        public static string sftp_ip;
        public static string ipAlias;
        public static string svmport;
        public static string sftp_port;
        private static string settings = Application.StartupPath + @"\settings.ini";
        private static string accountinfo = Application.StartupPath + @"\account.ini";
        private ClientWebSocket webSocket;
        private CancellationTokenSource cancellationTokenSource;
        private string serverIdentifier;
        private HttpClient httpClient;
        private DataTable datatable;


        public FrmServerControler(string serverIdentifier)
        {
            InitializeComponent();
            commandTextBox.KeyPress += commandTextBox_KeyPress;
            this.serverIdentifier = serverIdentifier;
            ServerId = serverIdentifier;
            httpClient = new HttpClient();
            datatable = new DataTable();
            AddColumnsToDataTable();
            dataTable.DataSource = datatable;

        }

        private async void loadWebsocket()
        {
            timer1.Stop();
            timer1.Start();
            try
            {
                var client = new RestClient(FrmLogin.panel_url);
                var request = new RestRequest($"/api/client/servers/{ServerId}/websocket", Method.Get);
                request.AddHeader("Authorization", $"Bearer {FrmLogin.user_api_key}");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var serverInfo = JObject.Parse(response.Content);

                    string token = serverInfo["data"]["token"].ToString();
                    string socket = serverInfo["data"]["socket"].ToString();

                    wsuri = socket;
                    authToken = token;
                }
                else
                {
                    MessageBox.Show($"Failed to fetch server information. Error: {response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                webSocket = new ClientWebSocket();
                webSocket.Options.SetRequestHeader("Origin", FrmLogin.panel_url);

                await webSocket.ConnectAsync(new Uri(wsuri), CancellationToken.None);
                cancellationTokenSource = new CancellationTokenSource();

                await AuthenticateWebSocket();
                await ReceiveConsoleOutput(cancellationTokenSource.Token);


            }
            catch (Exception ex)
            {
                MessageBox.Show("[WEBSOCKET LOADER] Failed to connect to the websocket: " + ex.Message);
                Console.WriteLine("[WEBSOCKET LOADER] Failed to connect to the websocket: " + ex.Message);
            }
        }
        private void loadSettings()
        {
            var cfg = new ConfigParser(settings);
            string allontop = cfg.GetValue("CONFIG", "always_on_top");
            if (allontop == "true")
            {
                this.TopMost = true;
            }
        }
        private void isMcSv()
        {
            string url = "https://api.mcsrvstat.us/2/" + ipAlias + ":" + svmport;
            string json = new WebClient().DownloadString(url);
            JObject data = JObject.Parse(json);
            bool isOnline = (bool)data["online"];
            if (isOnline)
            {
                string imageDataUri = (string)data["icon"];
                string base64Data = imageDataUri.Split(',')[1];
                byte[] imageData = Convert.FromBase64String(base64Data);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    pcsvimg.Image = image;
                }

            }
        }
        private void loadServerInfo()
        {
            try
            {
                var client = new RestClient(FrmLogin.panel_url);
                var request = new RestRequest($"/api/client/servers/{ServerId}", Method.Get);
                request.AddHeader("Authorization", $"Bearer {FrmLogin.user_api_key}");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var serverInfo = JObject.Parse(response.Content);

                    string serverName = serverInfo["attributes"]["name"].ToString();
                    string serverNode = serverInfo["attributes"]["node"].ToString();
                    string serverDescription = serverInfo["attributes"]["description"].ToString();
                    string servermaxram = serverInfo["attributes"]["limits"]["memory"].ToString();
                    string servermaxdisk = serverInfo["attributes"]["limits"]["disk"].ToString();
                    string servermaxcpu = serverInfo["attributes"]["limits"]["cpu"].ToString();

                    if (servermaxram == "0")
                    {
                        lblram.Text = "Ram: Unlimited";
                    }
                    else
                    {
                        lblram.Text = "Ram: " + servermaxram;
                    }
                    if (servermaxdisk == "0")
                    {
                        lbldisk.Text = "Disk: Unlimited";
                    }
                    else
                    {
                        lbldisk.Text = "Disk: " + servermaxdisk;
                    }
                    if (servermaxcpu == "0")
                    {
                        lblcpu.Text = "Cpu: Unlimited";
                    }
                    else
                    {
                        lblcpu.Text = "Cpu: " + servermaxcpu;
                    }

                    sftp_port = serverInfo["attributes"]["sftp_details"]["port"].ToString();
                    sftp_ip = serverInfo["attributes"]["sftp_details"]["ip"].ToString();
                    svname.Text = "Name: " + serverName;
                    svnode.Text = "Node: " + serverNode;
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
                    MessageBox.Show($"Failed to fetch server information. Error: {response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching server information. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void FrmMain_Load(object sender, EventArgs e)
        {
            Pages.TabSize = new Size(0, 0);
            loadWebsocket();
            timer1.Interval = 840000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            loadSettings();
            timer1.Start();
            Pages.SelectedPage = tab1;
            loadServerInfo();
            isMcSv();
            await LoadDatabases();
        }
        private void AddColumnsToDataTable()
        {
            datatable.Columns.Add("ID", typeof(string));
            datatable.Columns.Add("Name", typeof(string));
            datatable.Columns.Add("Username", typeof(string));
            datatable.Columns.Add("Host Address", typeof(string));
            datatable.Columns.Add("Host Port", typeof(int));
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
                var apiUrl = $"{FrmLogin.panel_url}/api/client/servers/{ServerId}/databases?include=password";

                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("Authorization", $"Bearer {FrmLogin.user_api_key}");

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
                        MessageBox.Show("Failed to parse JSON from response.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to load databases. Response: {errorResponse}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(errorResponse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }



        private async Task AuthenticateWebSocket()
        {
            var authPayload = new
            {
                @event = "auth",
                args = new object[] { authToken }
            };

            var jsonPayload = JsonConvert.SerializeObject(authPayload);
            var authBytes = Encoding.UTF8.GetBytes(jsonPayload);
            await webSocket.SendAsync(new ArraySegment<byte>(authBytes), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        private async Task ReceiveConsoleOutput(CancellationToken cancellationToken)
        {
            try
            {
                var buffer = new byte[1024];
                while (!cancellationToken.IsCancellationRequested && webSocket.State == WebSocketState.Open)
                {
                    var receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);
                    if (receiveResult.MessageType == WebSocketMessageType.Text)
                    {
                        var consoleOutput = Encoding.UTF8.GetString(buffer, 0, receiveResult.Count);
                        UpdateConsoleOutput(consoleOutput);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void UpdateConsoleOutput(string consoleOutput)
        {
            if (consoleTextBox.InvokeRequired)
            {
                consoleTextBox.Invoke(new Action<string>(UpdateConsoleOutput), consoleOutput);
            }
            else
            {

                try
                {
                    var cleanOutput = RemoveEscapeSequences(consoleOutput);
                    var payload = JObject.Parse(cleanOutput);
                    if (payload.ContainsKey("event") && payload["event"].ToString() == "console output")
                    {
                        var args = payload["args"];
                        if (args != null && args.Count() > 0)
                        {
                            var output = args[0].ToString();
                            var cleanedOutput = RemoveEscapeSequences(output);
                            consoleTextBox.AppendText(cleanedOutput + Environment.NewLine);
                            consoleTextBox.SelectionStart = consoleTextBox.Text.Length;
                            consoleTextBox.ScrollToCaret();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Sorry we can't handle this console output please do not use this command or please wait for a bug fix");
                    FrmServerControler x = new FrmServerControler(ServerId);
                    x.Show();
                    this.Hide();
                }

            }
        }
        private string RemoveEscapeSequences(string input)
        {
            var excludedPatterns = new List<string>
    {
        @"[m",
        @"[38;2;255;255;255m",
        @"[38;2;255;170;0m",
        @"[38;2;255;255;85m",
        @"[38;2;170;170;170m",
        @"[[0;34;22m",
        @">[2K",
        @"[0;30;22m",
        @"[0;31;22m[21m[4m",
        @"[0;37;22m",
        @"[0;31;1m",
        @"[0;31;1m[21m",
        @"[2K",
        @"[0;37;1m",
        @"[21m",
        @"[",
        @"1m33mcontainer@pterodactyl~ 0mjava -version",
        @"1m33m",
        @"0m",
        @"33m1m",
        @"39m",
        @"38;2;255;170;",
        @"38;2;170;170;17",
        @"33m",
        @"0;33;1m",
        @"0;33;22m",
        @"0;32;1m",
        @"0;32;22m",
        @"0;30;1m",
        @"0;36;1m",
        @"0;36;22m",
        @"39;",
        @"0;31;22m",
        @";8eeab68",
        @"32;22m",
        @"33;1m",
        @"1m",
        @"38;2;85;255;255m",
        @"38;2;85;255;85m",
        @"*",
        @"0;31;"
    };

            foreach (var pattern in excludedPatterns)
            {
                input = Regex.Replace(input, Regex.Escape(pattern), string.Empty);
            }

            return input;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            cancellationTokenSource?.Cancel();
            webSocket?.Dispose();
            base.OnFormClosing(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Alert("Your time is out!", FrmAlert.enmType.Warning);
            FrmMain x = new FrmMain();
            x.Show();
            this.Hide();
        }

        private void commandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("This thing dose not work yet so please click on the button to send the cmd to the server console!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OnFormClosing(null);
            Environment.Exit(0x0);
            Application.Exit();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            FrmProfile x = new FrmProfile();
            x.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmProfile x = new FrmProfile();
            x.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmSettings x = new FrmSettings();
            x.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var cfg = new ConfigParser(accountinfo);
            cfg.SetValue("LOGIN", "remember_me", "false");
            cfg.Save();
            FrmLogin x = new FrmLogin();
            x.Show();
            this.Hide();
        }
        static bool IsWinSCPInstalled()
        {
            string winscpPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "WinSCP", "WinSCP.exe");
            return File.Exists(winscpPath);
        }
        private void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            bool isWinSCPInstalled = IsWinSCPInstalled();
            if (isWinSCPInstalled)
            {
                string command = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "WinSCP", "WinSCP.exe");
                string arguments = @"sftp://" + FrmLogin.username + "." + ServerId + ":" + FrmLogin.panel_pwd + "@" + sftp_ip + ":" + sftp_port + "";
                ProcessStartInfo processInfo = new ProcessStartInfo(command, arguments);
                processInfo.RedirectStandardOutput = true;
                processInfo.UseShellExecute = false;

                Process process = Process.Start(processInfo);
            }
            else
            {
                Alert("WinSCP is not installed please install it to use this", FrmAlert.enmType.Warning);
            }
        }


        private void btnsend_Click(object sender, EventArgs e)
        {
            if (commandTextBox.Text == "")
            {
                MessageBox.Show("What cmd do you want to execute?");
            }
            try
            {
                var client = new RestClient(FrmLogin.panel_url);
                var request = new RestRequest($"/api/client/servers/{ServerId}/command", Method.Post);
                request.AddHeader("Authorization", $"Bearer {FrmLogin.user_api_key}");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddParameter("command", commandTextBox.Text);

                var response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    MessageBox.Show($"Failed to send command. Error: {response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the command. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            commandTextBox.Text = string.Empty;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmMain x = new FrmMain();
            x.Show();
            this.Hide();
        }

        private void svshutdown_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(FrmLogin.panel_url);
                var request = new RestRequest($"/api/client/servers/{ServerId}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {FrmLogin.user_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"stop\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Server shutdown request sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to send server shutdown request. Error: {response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"{response.Content}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the server shutdown request. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"An error occurred while sending the server shutdown request. Error: {ex.Message}");
            }
        }

        private void svstart_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(FrmLogin.panel_url);
                var request = new RestRequest($"/api/client/servers/{ServerId}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {FrmLogin.user_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"start\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Server start request sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to send server start request. Error: {response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"{response.Content}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the server start request. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"An error occurred while sending the server start request. Error: {ex.Message}");
            }
        }

        private void svrestart_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(FrmLogin.panel_url);
                var request = new RestRequest($"/api/client/servers/{ServerId}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {FrmLogin.user_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"restart\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Server restart request sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to send server restart request. Error: {response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"{response.Content}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the server restart request. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"An error occurred while sending the server restart request. Error: {ex.Message}");
            }
        }

        private void svkill_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient(FrmLogin.panel_url);
                var request = new RestRequest($"/api/client/servers/{ServerId}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {FrmLogin.user_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"kill\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Server kill request sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to send server kill request. Error: {response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"{response.Content}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the server kill request. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"An error occurred while sending the server kill request. Error: {ex.Message}");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Pages.SelectedPage = tab1;
            btndbs.FillColor = Color.FromArgb(34, 39, 57);
            btnconsole.FillColor = Color.FromArgb(27, 28, 46);
        }

        private void btndbs_Click(object sender, EventArgs e)
        {
            Pages.SelectedPage = tab2;
            btndbs.FillColor = Color.FromArgb(27, 28, 46);
            btnconsole.FillColor = Color.FromArgb(34, 39, 57);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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
