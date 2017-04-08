namespace _02.Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;

    public class CitiesByContinentAndCountry
    {
        // Write a program to read continents, countries and their cities, 
        // put them in a nested dictionary and print them.

        public static void Main(string[] args)
        {
            var towns = new Dictionary<string, Dictionary<string, List<string>>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var lineData = Console.ReadLine().Split();
                var continent = lineData[0];
                var country = lineData[1];
                var town = lineData[2];

                AddTown(towns, continent, country, town);
            }

            foreach (var continent in towns.Keys)
            {
                Console.WriteLine("{0}:", continent);

                var townsInContinent = towns[continent];
                var countries = townsInContinent.Keys;

                foreach (var country in townsInContinent.Keys)
                {
                    Console.WriteLine("  {0} -> {1}",
                        country,
                        string.Join(", ", townsInContinent[country]));
                }
            }
        }

        private static void AddTown(
            Dictionary<string, Dictionary<string, List<string>>> towns,
            string continent, string country, string town)
        {
            if (!towns.ContainsKey(continent))
            {
                towns[continent] = new Dictionary<string, List<string>>();
            }

            if (!towns[continent].ContainsKey(country))
            {
                towns[continent][country] = new List<string>();
            }

            towns[continent][country].Add(town);
        }
    }
}