using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pterodactyl.Handlers
{
    public class TelemetryHandler
    {
        public static async void InstallTools()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.mythicalsystems.me/telemetry?authKey=AxWTnecj85SI4bG6rIP8bvw2uCF7W5MmkJcQIkrYS80MzeTraQWyICL690XOio8F&project=pterodactyl-desktop&action=InstallTools"),
                Headers =
    {
        { "User-Agent", "insomnia/8.2.0" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        public static async void Login()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.mythicalsystems.me/telemetry?authKey=AxWTnecj85SI4bG6rIP8bvw2uCF7W5MmkJcQIkrYS80MzeTraQWyICL690XOio8F&project=pterodactyl-desktop&action=Login"),
                Headers =
    {
        { "User-Agent", "insomnia/8.2.0" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
