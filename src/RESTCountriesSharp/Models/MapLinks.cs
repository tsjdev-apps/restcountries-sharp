using Newtonsoft.Json;

namespace RESTCountriesSharp.Models
{
    public class MapLinks
    {
        [JsonProperty("googleMaps")]
        public string GoogleMaps { get; set; }

        [JsonProperty("OpenStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }
}
