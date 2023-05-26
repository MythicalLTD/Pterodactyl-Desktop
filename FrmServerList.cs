using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PteroControler
{
    public partial class FrmServerList : Form
    {
        private HttpClient httpClient;
        public FrmServerList()
        {
            InitializeComponent();
            serverListBox.SelectedIndex = -1;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {FrmLogin.user_api_key}");
        }
        private bool isFirstLoad = true;
        private async void FrmServerList_Load(object sender, EventArgs e)
        {
            label1.Text = "Hi, "+FrmLogin.username;
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public class PterodactylApiResponse
        {
            public List<ServerData> Data { get; set; }
        }

        public class ServerData
        {
            public ServerAttributes Attributes { get; set; }
        }

        public class ServerAttributes
        {
            
            public string Identifier { get; set; }
            public string Name { get; set; }
        }

        private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad)
            {
                isFirstLoad = false; 
                return;
            }
            string selectedServerName = serverListBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedServerName))
            {
                // Extract the identifier from the selected server name
                string identifier = selectedServerName.Substring(selectedServerName.IndexOf('(') + 1);
                identifier = identifier.TrimEnd(')');

                FrmServerControler serverDetailsForm = new FrmServerControler(identifier);
                serverDetailsForm.Show();
            }
        }
    }
    
}
