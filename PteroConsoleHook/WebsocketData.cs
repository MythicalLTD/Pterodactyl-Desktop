using Newtonsoft.Json;

namespace Pterodactyl.PteroConsoleHook
{
    public class WebsocketData
    {
        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("socket")]
        public string? Socket { get; set; }
    }
}
