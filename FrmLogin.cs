using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace PteroController;

public partial class FrmLogin : Form
{
    public static string? panel_url;
    public static string? panel_id;
    public static string? panel_api_key;
    public static string? panel_email;
    public static string? panel_password;
    public static string? panel_username;
    public static string? panel_first_name;
    public static string? panel_last_name;
    public static string? panel_admin;
    public static string panel_language = "en";

    public FrmLogin()
    {
        InitializeComponent();
    }
    private async Task<bool> Login(string apiKey, Uri panelUri)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = panelUri;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/client/account");

                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private async Task<string?> GetUserInfo(string apiKey, Uri panelUri)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = panelUri;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/client/account");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return jsonResponse;
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }
    }
    private async void btnlogin_Click(object sender, EventArgs e)
    {
        if (txtpanelurl.Text == "" && txtpanelapikey.Text == "")
        {
            MessageBox.Show("Please fill in all required information");
        }
        else
        {
            string apiKey = txtpanelapikey.Text;
            string panelUrl = txtpanelurl.Text;

            if (!Uri.TryCreate(panelUrl, UriKind.Absolute, out Uri panelUri))
            {
                MessageBox.Show("Invalid Pterodactyl Panel URL");
            }
            bool loginSuccess = await Login(apiKey, panelUri);
            if (loginSuccess)
            {
                try
                {
                    string userInfo = await GetUserInfo(apiKey, panelUri);
                    if (userInfo != null)
                    {
                        JObject userObject = JObject.Parse(userInfo);
                        JObject attributes = (JObject)userObject["attributes"];
                        panel_id = attributes["id"].ToString();
                        panel_admin = attributes["admin"].ToString();
                        panel_username = attributes["username"].ToString();
                        panel_email = attributes["email"].ToString();
                        panel_first_name = attributes["first_name"].ToString();
                        panel_last_name = attributes["last_name"].ToString();
                        panel_language = attributes["language"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Faild to get your data please check the panel url");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                panel_url = panelUrl;
                panel_api_key = apiKey;
                FrmServerSelector x = new FrmServerSelector();
                x.Show();
                this.Hide();
            }

        }

    }
}