using System;
using System.Collections.Generic;

namespace Pluralsight.BegCShCollections.ReadAllCountries
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = @"D:\.NET\pluralsight\TopTenPops\Pop by Largest Final.csv";
      CsvReader reader = new CsvReader(filePath);
      List<Country> countries = reader.ReadAllCountries();
      Country liliput = new Country("Liliput", "LIL", "Somewhere", 2_000_000);
      int liliputIndex = countries.FindIndex(x=>x.Population < 2_000_000);
      countries.Insert(liliputIndex, liliput);
      countries.RemoveAt(liliputIndex);

      foreach (Country country in countries)
      {
        Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
      }
      Console.WriteLine($"{countries.Count} countries");
    }
  }
}
