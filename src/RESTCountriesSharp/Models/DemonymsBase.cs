using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class DemonymsBase
    {
        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }
}
