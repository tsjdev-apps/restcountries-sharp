using Newtonsoft.Json;
using System.Collections.Generic;

namespace RESTCountriesSharp.Models
{
    public class NameInfo
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("nativeName")]
        public Dictionary<string, TranslationInfo> NativeNames { get; set; }
    }
}
