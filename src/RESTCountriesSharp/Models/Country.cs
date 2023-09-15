using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RESTCountriesSharp.Models
{
    public class Country
    {
        [JsonProperty("name")]
        public NameInfo Name { get; set; }

        [JsonProperty("tld")]
        public string[] TopLevelDomains { get; set; }

        [JsonProperty("cca2")]
        public string Alpha2Code { get; set; }

        [JsonProperty("ccn3")]
        public string Iso3166Code { get; set; }

        [JsonProperty("cca3")]
        public string Alpha3CCode { get; set; }

        [JsonProperty("cioc")]
        public string IOCCode { get; set; }

        [JsonProperty("independent")]
        public bool? IsIndependent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("unMember")]
        public bool IsMemberOfUN { get; set; }

        [JsonProperty("currencies")]
        public Dictionary<string, CurrencyInfo> Currencies { get; set; }

        [JsonProperty("idd")]
        public IDDInfo InternationalDirectDialing { get; set; }

        [JsonProperty("capital")]
        public string[] Capitals { get; set; }

        [JsonProperty("altSpellings")]
        public string[] AlternativeSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("languages")]
        public Dictionary<string, string> Languages { get; set; }

        [JsonProperty("translations")]
        public Dictionary<string, TranslationInfo> Translations { get; set; }

        [JsonProperty("latlng")]
        public double[] LatLng { get; set; }

        public double? Latitude => LatLng.FirstOrDefault();
        public double? Longitude => LatLng.LastOrDefault();

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("demonyms")]
        public DemonymsInfo Demonyms { get; set; }

        [JsonProperty("flag")]
        public string UnicodeFlag { get; set; }

        [JsonProperty("maps")]
        public MapLinks MapLinks { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

        [JsonProperty("gini")]
        public Dictionary<string,double> GiniCoefficient { get; set; }

        [JsonProperty("fifa")]
        public string Fifa { get; set; }

        [JsonProperty("timezones")]
        public string[] Timezones { get; set; }
        
        [JsonProperty("continents")]
        public string[] Continents { get; set; }

        [JsonProperty("flags")]
        public ImageInfo Flag { get; set; }

        [JsonProperty("coatOfArms")]
        public ImageInfo CoatOfArms { get; set; }

        [JsonProperty("car")]
        public CarInfo Car { get; set; }

        [JsonProperty("startOfWeek")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek StartOfWeek { get; set; }

        [JsonProperty("capitalInfo")]
        public CapitalInfo CapitalInfo { get; set; }

        [JsonProperty("postalcode")]
        public PostalCode PostalCode { get; set; }
    }
}
