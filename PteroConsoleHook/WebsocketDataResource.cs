using Newtonsoft.Json;

namespace PteroController.PteroConsoleHook
{
    public class WebsocketDataResource
    {
        [JsonProperty("data")]
        public WebsocketData? Data { get; set; }
    }

}
