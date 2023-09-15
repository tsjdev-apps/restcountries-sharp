using RESTCountriesSharp;
using RESTCountriesSharp.Models;
using Spectre.Console;

RESTCountriesSharpService restCountriesSharp = new();

AnsiConsole.Write(new FigletText("RESTCountries Sharp").LeftJustified().Color(Color.Red));

IEnumerable<Country> countries = new List<Country>();

await AnsiConsole.Status().StartAsync("Getting european countries...", async ctx =>
{
    countries = await restCountriesSharp.GetCountriesByRegionAsync("europe");
    countries = countries.OrderBy(c => c.Name.Common);
});

AnsiConsole.MarkupLine($"[green]Here are {countries.Count()} countries:[/]");

Table table = new Table()
    .AddColumn(new TableColumn("Name").LeftAligned())
    .AddColumn(new TableColumn("Region").LeftAligned())
    .AddColumn(new TableColumn("Latitude").LeftAligned())
    .AddColumn(new TableColumn("Longitude").LeftAligned())
    .AddColumn(new TableColumn("Capital").LeftAligned());

AnsiConsole.Live(table)
           .Start(ctx =>
           {
               foreach (Country country in countries)
               {
                   table.AddRow(country.Name.Common, country.Region, country.Latitude?.ToString() ?? "-", country.Longitude?.ToString() ?? "-", country.Capitals is not null ? string.Join(", ", country.Capitals) : "-");
                   ctx.Refresh();
                   Thread.Sleep(100);
               }
           });
