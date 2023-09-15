using Newtonsoft.Json;
using RESTCountriesSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RESTCountriesSharp
{
    public class RESTCountriesSharpService : IRESTCountriesSharpService
    {
        private HttpClient _httpClient;

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            string endpoint = "all";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        public async Task<IEnumerable<Country>> GetCountriesByNameAsync(string name)
        {
            string endpoint = $"name/{name}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        public async Task<Country> GetCountryByFullNameAsync(string fullName)
        {
            string endpoint = $"name/{fullName}?fullText=true";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries.FirstOrDefault();
        }

        public async Task<Country> GetCountryByCodeAsync(string code)
        {
            string endpoint = $"alpha/{code}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries.FirstOrDefault();
        }

        public async Task<IEnumerable<Country>> GetCountriesByCodesAsync(IEnumerable<string> codes)
        {
            string endpoint = $"alpha?codes={string.Join(",", codes)}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        public async Task<IEnumerable<Country>> GetCountriesByCurrencyAsync(string currency)
        {
            string endpoint = $"currency/{currency}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        public async Task<IEnumerable<Country>> GetCountriesByLanguageAsync(string language)
        {
            string endpoint = $"lang/{language}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        public async Task<IEnumerable<Country>> GetCountriesByCapitalAsync(string capital)
        {
            string endpoint = $"capital/{capital}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        public async Task<IEnumerable<Country>> GetCountriesByRegionAsync(string region)
        {
            string endpoint = $"region/{region}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        public async Task<IEnumerable<Country>> GetCountriesBySubregionAsync(string subregion)
        {
            string endpoint = $"subregion/{subregion.Replace(" ", "%20")}";

            IEnumerable<Country> countries = await GetCountriesListAsync(endpoint);
            return countries;
        }

        private async Task<IEnumerable<Country>> GetCountriesListAsync(string endpoint)
        {
            try
            {
                HttpClient client = GetHttpClient();

                HttpResponseMessage responseMessage = await client.GetAsync(endpoint);
                responseMessage.EnsureSuccessStatusCode();

                string body = await responseMessage.Content.ReadAsStringAsync();

                IEnumerable<Country> countries = JsonConvert.DeserializeObject<IEnumerable<Country>>(body);
                return countries;
            }
            catch
            {
                return Enumerable.Empty<Country>();
            }
        }

        private HttpClient GetHttpClient()
        {
            if (_httpClient != null)
            {
                return _httpClient;
            }

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://restcountries.com/v3.1/")
            };

            return _httpClient;
        }
    }
}
