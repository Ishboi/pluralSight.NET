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
      Dictionary<string, Country> countries = reader.ReadAllCountries();

      Console.WriteLine("Which country code do you want to look up? ");
      string userInput = Console.ReadLine();

      bool gotCountry = countries.TryGetValue(userInput, out Country country);
      if (!gotCountry)
      {
        Console.WriteLine($"Sorry, there is no country with code, {userInput}");
      }
      else
      {
        Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
      }
    }
  }
}
