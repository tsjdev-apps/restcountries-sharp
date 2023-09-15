using Newtonsoft.Json;
using System.Linq;

namespace RESTCountriesSharp.Models
{
    public class CapitalInfo
    {
        [JsonProperty("latlng")]
        public double[] LatLng { get; set; }

        public double? Latitude => LatLng.FirstOrDefault();
        public double? Longitude => LatLng.LastOrDefault();

    }
}
