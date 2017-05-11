namespace Problem_4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class NSA
    {
        // Most people have probably heard the news about some dummy named Edward Snowden, who released 
        // some info about an American association called the NSA, which, by his words, was spying on 
        // innocent citizens.Who cares anyways, it’s America, not my country.Yeah well … Guess again, NSA is Global.

        // The NSA creates a registry of spies.The input of data comes in the following format:
        // {countryName} -> {spyName} -> {daysInService}

        // The countryName and the spyName are both strings which may contain alphanumeric characters.
        // The daysInService is an integer.
        // If you get an existent country, add the new spy to it.If even the spy exists, update its 
        // daysInService, with the new given value.
        // When you get the command “quit”, you terminate the program. Then you must print all countries and their spies.
        // The countries must be ordered by amount of spies they have in descending order.
        // The spies must be ordered by days in service, in descending order.

        // Input
        // # The input comes in the format specified above.
        // # The input sequence ends when you receive the “quit” command.

        // Output
        // # The countries and their spies must be printed in the following format:
        // “Country: {country1Name}
        // **{spy1Name} : {spy1Score}
        // **{spy2Name} : {spy2Score}
        // . . . 
        // Country: {country2Name}
        // . . .”

        public static void Main(string[] args)
        {
            // 40 / 100

            var inventory = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "quit")
            {
                var tokens = inputLine
                    .Trim()
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var countryName = tokens[0];
                var spyName = tokens[1];
                var days = int.Parse(tokens[2]);

                if (!inventory.ContainsKey(countryName))
                {
                    inventory[countryName] = new Dictionary<string, int>();
                }

                if (!inventory[countryName].ContainsKey(spyName))
                {
                    inventory[countryName][spyName] = days;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var country in inventory.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");

                foreach (var spy in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
