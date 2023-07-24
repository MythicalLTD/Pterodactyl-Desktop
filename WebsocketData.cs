using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PteroController
{
    public class WebsocketDataResource
    {
        [JsonProperty("data")]
        public WebsocketData Data { get; set; }
    }

    public class WebsocketData
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("socket")]
        public string Socket { get; set; }
    }
}
