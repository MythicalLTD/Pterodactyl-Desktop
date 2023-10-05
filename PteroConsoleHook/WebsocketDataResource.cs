using Newtonsoft.Json;

namespace Pterodactyl.PteroConsoleHook
{
    public class WebsocketDataResource
    {
        [JsonProperty("data")]
        public WebsocketData? Data { get; set; }
    }

}
