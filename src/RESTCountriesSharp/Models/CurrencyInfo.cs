using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class CurrencyInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}
