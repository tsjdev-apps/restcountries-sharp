using Refit;
using RESTCountriesSharp.Clients;
using RESTCountriesSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTCountriesSharp
{
    public class RESTCountriesService : IRESTCountriesService
    {
        private readonly IRESTCountriesClient _restCountriesClient;

        public RESTCountriesService()
        {
            _restCountriesClient = RestService.For<IRESTCountriesClient>("https://restcountries.com/v3.1", new RefitSettings { ContentSerializer = new NewtonsoftJsonContentSerializer() });
        }

        public async Task<Country> GetCountryByFullNameAsync(string fullName)
        {
            IEnumerable<Country> countries = await RunAndHandleErrorAsync(async () =>
            {
                return await _restCountriesClient.GetCountriesByFullNameAsync(fullName);
            });

            return countries?.FirstOrDefault();
        }

        public async Task<Country> GetCountryByCodeAsync(string code)
        {
            IEnumerable<Country> countries = await RunAndHandleErrorAsync(async () =>
            {
                return await _restCountriesClient.GetCountriesByCodeAsync(code);
            });

            return countries?.FirstOrDefault();
        }

        public Task<IEnumerable<Country>> GetAllCountriesAsync()
            => RunAndHandleErrorAsync(async () => await _restCountriesClient.GetAllCountriesAsync());

        public Task<IEnumerable<Country>> GetCountriesByNameAsync(string name)
            => RunAndHandleErrorAsync(async () => await _restCountriesClient.GetCountriesByNameAsync(name));

        public Task<IEnumerable<Country>> GetCountriesByCodesAsync(IEnumerable<string> codes)
            => RunAndHandleErrorAsync(async () => await _restCountriesClient.GetCountriesByCodesAsync(string.Join(",", codes)));

        public async Task<IEnumerable<Country>> GetCountriesByCurrencyAsync(string currency)
            => await RunAndHandleErrorAsync(async () => await _restCountriesClient.GetCountriesByCurrencyAsync(currency));

        public async Task<IEnumerable<Country>> GetCountriesByLanguageAsync(string language) 
            => await RunAndHandleErrorAsync(async () => await _restCountriesClient.GetCountriesByLanguageAsync(language));

        public async Task<IEnumerable<Country>> GetCountriesByCapitalAsync(string capital) 
            => await RunAndHandleErrorAsync(async () => await _restCountriesClient.GetCountriesByCapitalAsync(capital));

        public async Task<IEnumerable<Country>> GetCountriesByRegionAsync(string region) 
            => await RunAndHandleErrorAsync(async () => await _restCountriesClient.GetCountriesByRegionAsync(region));

        public async Task<IEnumerable<Country>> GetCountriesBySubregionAsync(string subregion) 
            => await RunAndHandleErrorAsync(async () => await _restCountriesClient.GetCountriesBySubregionAsync(subregion));

        private async Task<IEnumerable<Country>> RunAndHandleErrorAsync(Func<Task<IEnumerable<Country>>> func)
        {
            try
            {
                return await func();
            }
            catch
            {
                return Enumerable.Empty<Country>();
            }
        }
    }
}
