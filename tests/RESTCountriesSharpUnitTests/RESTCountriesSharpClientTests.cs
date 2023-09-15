using FluentAssertions;
using RESTCountriesSharp;
using RESTCountriesSharp.Models;

namespace RESTCountriesSharpUnitTests;

public class RESTCountriesSharpClientTests
{
    private readonly RESTCountriesSharpService _service;

    public RESTCountriesSharpClientTests()
    {
        _service = new RESTCountriesSharpService();
    }

    [Fact]
    public async Task GetAllCountriesTests_ReturnValues()
    {
        // ACT
        IEnumerable<Country> result = await _service.GetAllCountriesAsync();

        // ASSERT
        result.Should().NotBeEmpty();
    }

    [Fact]
    public async Task GetCountriesByNameTests_ReturnValues()
    {
        // ACT
        IEnumerable<Country> result = await _service.GetCountriesByNameAsync("a");

        // ASSERT
        result.Should().NotBeEmpty();
        result.Should().Contain(c => c.Name.Common.Equals("France"));
        result.Should().Contain(c => c.Name.Common.Equals("Spain"));
        result.Should().Contain(c => c.Name.Common.Equals("Italy"));
        result.Should().Contain(c => c.Name.Common.Equals("Germany"));
    }

    [Fact]
    public async Task GetCountriesByNameTests_IsEmpty()
    {
        // ACT
        IEnumerable<Country> result = await _service.GetCountriesByNameAsync("xxxxxx");

        // ASSERT
        result.Should().BeEmpty();
    }

    [Fact]
    public async Task GetCountryByFullNameTest_ReturnValue()
    {
        // ACT
        Country germany = await _service.GetCountryByFullNameAsync("Germany");

        // ASSERT
        germany.Should().NotBeNull();
        germany.Name.Common.Should().Be("Germany");

    }

    [Fact]
    public async Task GetCountryByFullNameTest_ReturnNull()
    {
        // ACT
        Country nullResult = await _service.GetCountryByFullNameAsync("deu");

        // ASSERT
        nullResult.Should().BeNull();
    }

    [Fact]
    public async Task GetCountryByCodeAsync_ReturnValue()
    {
        // ACT
        Country germany = await _service.GetCountryByCodeAsync("deu");

        // ASSERT
        germany.Should().NotBeNull();
        germany.Name.Common.Should().Be("Germany");

    }

    [Fact]
    public async Task GetCountryByCodeAsync_ReturnNull()
    {
        // ACT
        Country nullResult = await _service.GetCountryByCodeAsync("germany");

        // ASSERT
        nullResult.Should().BeNull();
    }

    [Fact]
    public async Task GetCountriesByCodesAsync_ReturnValue()
    {
        // ACT
        IEnumerable<Country> countries = await _service.GetCountriesByCodesAsync(new List<string> { "deu", "no" });

        // ASSERT
        countries.Should().NotBeNull();
        countries.Should().Contain(c => c.Name.Common.Equals("Germany"));
        countries.Should().Contain(c => c.Name.Common.Equals("Norway"));
    }

    [Fact]
    public async Task GetCountriesByCurrencyAsync_ReturnValue()
    {
        // ACT
        IEnumerable<Country> countries = await _service.GetCountriesByCurrencyAsync("euro");

        // ASSERT
        countries.Should().NotBeNull();
        countries.Should().Contain(c => c.Name.Common.Equals("Germany"));
    }

    [Fact]
    public async Task GetCountriesByLanguageAsync_ReturnValue()
    {
        // ACT
        IEnumerable<Country> countries = await _service.GetCountriesByLanguageAsync("spanish");

        // ASSERT
        countries.Should().NotBeNull();
        countries.Should().Contain(c => c.Name.Common.Equals("Spain"));
        countries.Should().Contain(c => c.Name.Common.Equals("Mexico"));
    }

    [Fact]
    public async Task GetCountriesByCapitalAsync_ReturnValue()
    {
        // ACT
        IEnumerable<Country> countries = await _service.GetCountriesByCapitalAsync("berlin");

        // ASSERT
        countries.Should().NotBeNull();
        countries.Should().Contain(c => c.Name.Common.Equals("Germany"));
    }

    [Fact]
    public async Task GetCountriesByRegionAsync_ReturnValue()
    {
        // ACT
        IEnumerable<Country> countries = await _service.GetCountriesByRegionAsync("europe");

        // ASSERT
        countries.Should().NotBeNull();
        countries.Should().Contain(c => c.Name.Common.Equals("Germany"));
        countries.Should().Contain(c => c.Name.Common.Equals("Switzerland"));
        countries.Should().Contain(c => c.Name.Common.Equals("France"));
        countries.Should().Contain(c => c.Name.Common.Equals("Norway"));
        countries.Should().Contain(c => c.Name.Common.Equals("Sweden"));
    }

    [Fact]
    public async Task GetCountriesBySubregionAsync_ReturnValue()
    {
        // ACT
        IEnumerable<Country> countries = await _service.GetCountriesBySubregionAsync("northern europe");

        // ASSERT
        countries.Should().NotBeNull();
        countries.Should().Contain(c => c.Name.Common.Equals("Sweden"));
    }
}