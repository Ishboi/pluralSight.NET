﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.BegCShCollections.ReadAllCountries
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"D:\Courses\.NET\pluralsight\Collections\Pop by Largest Final.csv";
			CsvReader reader = new CsvReader(filePath);

			List<Country> countries = reader.ReadAllCountries();
			reader.RemoveCommaCountries(countries);

      Console.WriteLine("Enter no. of countries to display > ");
			bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
			if(!inputIsInt || userInput <= 0)
      {
        Console.WriteLine("You must type in a +ve integer. Exiting");
				return;
      }

			int maxToDisplay = userInput;
			//foreach (Country country in countries)
			for (int i = 0; i < countries.Count; i++)
			{
				if(i > 0 && (i % maxToDisplay == 0))
        {
          Console.WriteLine("Hit return to continue, anything else to quit >");
					if (Console.ReadLine() != "")
						break;
        }
				Country country = countries[i];
				Console.WriteLine($"{i+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}
		}
	}
}
