using Newtonsoft.Json;


namespace PteroControllerConsole;

public class WebsocketDataResource
{
    [JsonProperty("data")]
    public WebsocketData? Data { get; set; }
}