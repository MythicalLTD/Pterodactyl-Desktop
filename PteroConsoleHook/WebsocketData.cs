using Newtonsoft.Json;

namespace PteroController.PteroConsoleHook
{
    public class WebsocketData
    {
        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("socket")]
        public string? Socket { get; set; }
    }
}
