using System.Text.Json.Serialization;

namespace C969_Scheduling.ProcessModels
{
    public class IpInfo
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }
        [JsonPropertyName("region")]
        public string Region { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("loc")]
        public string Loc { get; set; }
        [JsonPropertyName("org")]
        public string Org { get; set; }
        [JsonPropertyName("postal")]
        public string Postal { get; set; }
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
        [JsonPropertyName("readme")]
        public string Readme { get; set; }

    }
}
