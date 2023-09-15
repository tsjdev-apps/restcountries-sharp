using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class DemonymsInfo
    {
        [JsonProperty("fra")]
        public DemonymsBase French { get; set; }

        [JsonProperty("eng")]
        public DemonymsBase English { get; set; }
    }
}
