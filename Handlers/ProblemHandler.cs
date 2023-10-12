using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pterodactyl.Handlers
{
    public class ProblemHandler
    {
        public static async void Warning(string title, string message)
        {
            if (RegistryHandler.GetSetting("DisableErrorReporting") == "false")
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://api.mythicalsystems.me/problem?authKey=AxWTnecj85SI4bG6rIP8bvw2uCF7W5MmkJcQIkrYS80MzeTraQWyICL690XOio8F&project=pterodactyl-desktop&type=warning&title={title}&message={message}"),
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
        public static async void Error(string title, string message)
        {
            if (RegistryHandler.GetSetting("DisableErrorReporting") == "false")
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://api.mythicalsystems.me/problem?authKey=AxWTnecj85SI4bG6rIP8bvw2uCF7W5MmkJcQIkrYS80MzeTraQWyICL690XOio8F&project=pterodactyl-desktop&type=error&title={title}&message={message}"),
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
        public static async void Critical(string title, string message)
        {
            if (RegistryHandler.GetSetting("DisableErrorReporting") == "false")
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://api.mythicalsystems.me/problem?authKey=AxWTnecj85SI4bG6rIP8bvw2uCF7W5MmkJcQIkrYS80MzeTraQWyICL690XOio8F&project=pterodactyl-desktop&type=critical&title={title}&message={message}"),
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
}
