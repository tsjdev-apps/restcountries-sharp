using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class PostalCode
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("regex")]
        public string Regex { get; set; }
    }
}
