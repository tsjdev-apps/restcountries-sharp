using RESTCountriesSharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RESTCountriesSharp
{
    public interface IRESTCountriesSharpService
    {
        /// <summary>
        ///     Get all countries.
        /// </summary>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetAllCountriesAsync();

        /// <summary>
        ///     Search by country name.
        /// </summary>
        /// <param name="name">Name of the country.</param>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetCountriesByNameAsync(string name);

        /// <summary>
        ///     Search by country's full name. 
        ///     It can be the common or official value
        /// </summary>
        /// <param name="fullName">The full name of the country.</param>
        /// <returns>A <see cref="Country"/> or `null`.</returns>
        Task<Country> GetCountryByFullNameAsync(string fullName);

        /// <summary>
        ///     Search by cca2, ccn3, cca3 or cioc country code.
        /// </summary>
        /// <param name="code">The code of the country.</param>
        /// <returns>A <see cref="Country"/> or `null`.</returns>
        Task<Country> GetCountryByCodeAsync(string code);

        /// <summary>
        ///     Search by cca2, ccn3, cca3 or cioc country code.
        /// </summary>
        /// <param name="codes">A list of country codes.</param>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetCountriesByCodesAsync(IEnumerable<string> codes);

        /// <summary>
        ///     Search by currency code or name.
        /// </summary>
        /// <param name="currency">The currency code or name.</param>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetCountriesByCurrencyAsync(string currency);

        /// <summary>
        ///     Search by language code or name.
        /// </summary>
        /// <param name="language">The language code or name.</param>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetCountriesByLanguageAsync(string language);

        /// <summary>
        ///     Search by capital city
        /// </summary>
        /// <param name="capital">The capital city.</param>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetCountriesByCapitalAsync(string capital);

        /// <summary>
        ///     Search by region.
        /// </summary>
        /// <param name="region">Name of the region.</param>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetCountriesByRegionAsync(string region);

        /// <summary>
        ///     Search by subregions.
        /// </summary>
        /// <param name="subregion">Name of the subregion.</param>
        /// <returns>A list of <see cref="Country"/>.</returns>
        Task<IEnumerable<Country>> GetCountriesBySubregionAsync(string subregion);
    }
}