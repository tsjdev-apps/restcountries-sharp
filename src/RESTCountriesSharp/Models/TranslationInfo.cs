using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class TranslationInfo
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }
}
