using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PteroControler
{
    public partial class FrmServerControler : Form
    {
        public static string ServerId;
        public static string authToken;
        public static string wsuri;
        private static string appConfig = Application.StartupPath + @"\settings.ini";
        private ClientWebSocket webSocket;
        private CancellationTokenSource cancellationTokenSource;
        private string serverIdentifier;
        public FrmServerControler(string serverIdentifier)
        {
            InitializeComponent();
            commandTextBox.KeyPress += commandTextBox_KeyPress;
            this.serverIdentifier = serverIdentifier;
            ServerId = serverIdentifier;
        }

        void LoadSettings()
        {
            
           
        }

        private void btnshutdown_Click(object sender, EventArgs e)
        {
            LoadSettings();
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

        private void btnstart_Click(object sender, EventArgs e)
        {
            LoadSettings();
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

        private void btnrestart_Click(object sender, EventArgs e)
        {
            LoadSettings();
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

        private void btnkill_Click(object sender, EventArgs e)
        {
            LoadSettings();
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

        private void btnopenconsole_Click(object sender, EventArgs e)
        {
            if (commandTextBox.Text == "")
            {
                MessageBox.Show("What cmd do you want to execute?");
            }
            LoadSettings();
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
        private async void loadWebsocket()
        {
            timer1.Stop();
            timer1.Start();
            try
            {
                LoadSettings();
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
                await webSocket.ConnectAsync(new Uri(wsuri), CancellationToken.None);
                cancellationTokenSource = new CancellationTokenSource();

                await AuthenticateWebSocket();
                await ReceiveConsoleOutput(cancellationTokenSource.Token);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the websocket: " + ex.Message);
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 840000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
            var cfg = new ConfigParser(appConfig);
            LoadSettings();
            timer1.Start();
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
                    svname.Text = "Name: " + serverName;
                    svnode.Text = "Node: " + serverNode;
                    svdescription.Text = "Description: " + serverDescription;
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

        private void UpdateConsoleOutput(string consoleOutput)
        {
            if (consoleTextBox.InvokeRequired)
            {
                consoleTextBox.Invoke(new Action<string>(UpdateConsoleOutput), consoleOutput);
            }
            else
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
        @"38;2;170;170;17"
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

        private void fetch_Click(object sender, EventArgs e)
        {
            LoadSettings();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadWebsocket();
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
    }
}

