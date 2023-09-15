using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RESTCountriesSharp.Models.Enums;

namespace RESTCountriesSharp.Models
{
    public class CarInfo
    {
        [JsonProperty("signs")]
        public string[] Signs { get; set; }

        [JsonProperty("side")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TrafficSide Side { get; set; }
    }
}
