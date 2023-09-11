using Newtonsoft.Json;
namespace PteroControllerConsole;

public class WebsocketData
{
    [JsonProperty("token")]
    public string? Token { get; set; }

    [JsonProperty("socket")]
    public string? Socket { get; set; }
}
