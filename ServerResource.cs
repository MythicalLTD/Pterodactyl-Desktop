using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PteroController
{
    public class ServerResource
    {
        [JsonProperty("memory_bytes")]
        public long MemoryBytes { get; set; }

        [JsonProperty("memory_limit_bytes")]
        public long MemoryLimitBytes { get; set; }

        [JsonProperty("cpu_absolute")]
        public float CpuAbsolute { get; set; }

        [JsonProperty("network")]
        public NetworkData Network { get; set; }

        [JsonProperty("uptime")]
        public double Uptime { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("disk_bytes")]
        public long DiskBytes { get; set; }

        public class NetworkData
        {
            [JsonProperty("rx_bytes")]
            public long RxBytes { get; set; }

            [JsonProperty("tx_bytes")]
            public long TxBytes { get; set; }
        }
    }
}
