namespace _04.Group_Continents__Countries_and_Cities
{
    using System;
    using System.Collections.Generic;

    public class GroupContinents_CountriesAndCities
    {
        // Write a program, which receives continents, countries and city names and prints them, 
        // grouped by continent, country and city, all in alphabetical order. 
        // No duplicates are allowed.

        public static void Main(string[] args)
        {
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continents = tokens[0];
                var country = tokens[1];
                var town = tokens[2];

                if (!data.ContainsKey(continents))
                {
                    data[continents] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!data[continents].ContainsKey(country))
                {
                    data[continents][country] = new SortedSet<string>();
                }

                data[continents][country].Add(town);
            }

            foreach (var continentAndCountry in data)
            {
                var continent = continentAndCountry.Key;
                var countryAndTowns = continentAndCountry.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countryAndCities in countryAndTowns)
                {
                    var country = countryAndCities.Key;
                    var town = countryAndCities.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ", town)}");
                }
            }
        }
    }
}