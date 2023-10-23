using Refit;
using RESTCountriesSharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RESTCountriesSharp.Clients
{
    internal interface IRESTCountriesClient
    {
        [Get("/all")]
        Task<IEnumerable<Country>> GetAllCountriesAsync();

        [Get("/name/{name}")]
        Task<IEnumerable<Country>> GetCountriesByNameAsync(string name);

        [Get("/name/{name}?fullText=true")]
        Task<IEnumerable<Country>> GetCountriesByFullNameAsync(string name);

        [Get("/alpha/{code}")]
        Task<IEnumerable<Country>> GetCountriesByCodeAsync(string code);

        [Get("/alpha")]
        Task<IEnumerable<Country>> GetCountriesByCodesAsync(string codes);

        [Get("/currency/{currency}")]
        Task<IEnumerable<Country>> GetCountriesByCurrencyAsync(string currency);

        [Get("/lang/{language}")]
        Task<IEnumerable<Country>> GetCountriesByLanguageAsync(string language);

        [Get("/capital/{capital}")]
        Task<IEnumerable<Country>> GetCountriesByCapitalAsync(string capital);

        [Get("/region/{region}")]
        Task<IEnumerable<Country>> GetCountriesByRegionAsync(string region);

        [Get("/subregion/{subregion}")]
        Task<IEnumerable<Country>> GetCountriesBySubregionAsync(string subregion);
    }
}
