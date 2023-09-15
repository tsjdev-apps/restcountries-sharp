using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class ImageInfo
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }

        [JsonProperty("alt")]
        public string Description { get; set; }
    }
}
