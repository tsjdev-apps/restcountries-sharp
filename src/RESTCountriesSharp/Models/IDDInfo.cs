using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class IDDInfo
    {
        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("suffixes")]
        public string[] Suffixes { get; set; }
    }
}
