# RESTCountries Sharp

A .NET client wrapper for https://restcountries.com written in .NET Standard 2.0

## Installation

Install the package via [NuGet](https://www.nuget.org/packages/RESTCountriesSharp).

<a href="https://www.nuget.org/packages/RESTCountriesSharp" target="_blank">![Nuget](https://img.shields.io/nuget/v/RESTCountriesSharp)</a>


## Usage

You can either create a new instance of `RESTCountriesService` or if you are using Dependency Injection there is also an interface called `IRESTCountriesService` which you can register in your container.

The service provides the following methods:

```csharp
/// <summary>
///     Get all countries.
/// </summary>
Task<IEnumerable<Country>> GetAllCountriesAsync();

/// <summary>
///     Search by country name.
/// </summary>
Task<IEnumerable<Country>> GetCountriesByNameAsync(string name);

/// <summary>
///     Search by country's full name. 
///     It can be the common or official value
/// </summary>
Task<Country> GetCountryByFullNameAsync(string fullName);

/// <summary>
///     Search by cca2, ccn3, cca3 or cioc country code.
/// </summary>
Task<Country> GetCountryByCodeAsync(string code);

/// <summary>
///     Search by cca2, ccn3, cca3 or cioc country code.
/// </summary>
Task<IEnumerable<Country>> GetCountriesByCodesAsync(IEnumerable<string> codes);

/// <summary>
///     Search by currency code or name.
/// </summary>
Task<IEnumerable<Country>> GetCountriesByCurrencyAsync(string currency);

/// <summary>
///     Search by language code or name.
/// </summary>
Task<IEnumerable<Country>> GetCountriesByLanguageAsync(string language);

/// <summary>
///     Search by capital city
/// </summary>
Task<IEnumerable<Country>> GetCountriesByCapitalAsync(string capital);

/// <summary>
///     Search by region.
/// </summary>
Task<IEnumerable<Country>> GetCountriesByRegionAsync(string region);

/// <summary>
///     Search by subregions.
/// </summary>
Task<IEnumerable<Country>> GetCountriesBySubregionAsync(string subregion);
```

## Sample

Here is a screenshot of the `Console Application` using the [NuGet package](https://www.nuget.org/packages/RESTCountriesSharp) to get the european countries and display them in a table on the console.

![RESTCountriesSharpSample](https://raw.githubusercontent.com/tsjdev-apps/restcountries-sharp/main/docs/sample-console.png)

There is also a [Postman](https://www.postman.com/) collection located in the [*Samples*](./samples/) folder. This collection contains all the different endpoints of the API and all the calls are also possible to do with the `RESTCountriesService`.

## Buy Me A Coffee

I appreciate any form of support to keep my _Open Source_ activities going.

Whatever you decide, be it reading and sharing my blog posts, using my NuGet packages or buying me a coffee/book, thank you ❤️.

<a href="https://www.buymeacoffee.com/tsjdevapps" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-yellow.png" alt="Buy Me A Coffee" height="41" width="174"></a>

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)