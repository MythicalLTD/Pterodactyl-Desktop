using System.Net.Http.Headers;

namespace PteroController.Pterodactyl.User
{
    public class Login
    {
        public static async Task<bool> Check(string apiKey, Uri panelUri)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine("Login Error: " + ex.Message);
                return false;
            }
        }
    }
}
