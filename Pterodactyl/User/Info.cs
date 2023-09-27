using Newtonsoft.Json.Linq;
using Salaros.Configuration;
using System.Net.Http.Headers;
#pragma warning disable
namespace PteroController.Pterodactyl.User
{
    public class Info
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
        public static string? panel_avatar;
        public static string panel_language = "en";
        private static async Task<string?> GetUserInfo(string apiKey, Uri panelUri)
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
        public static async         Task
Get(string panelUrl, string apiKey, string password)
        {
            if (!Uri.TryCreate(panelUrl, UriKind.Absolute, out Uri panelUri))
            {
                Program.Alert("Invalid Pterodactyl Panel URL", FrmAlert.enmType.Error);

            }
            bool loginSuccess = await Login.Check(apiKey, panelUri);
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
                        Program.Alert("Login failed", FrmAlert.enmType.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                panel_url = panelUrl;
                panel_api_key = apiKey;
                try
                {
                    var account = new ConfigParser(Program.AppAccountInfo);
                    account.SetValue("LOGIN", "panel_url", Base64Encryption.Encrypt(panelUrl));
                    account.SetValue("LOGIN", "api_key", Base64Encryption.Encrypt(apiKey));
                    account.SetValue("LOGIN", "panel_pwd", Base64Encryption.Encrypt(password));
                    account.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
