namespace _02.Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string key = inputParams[0];
                string value = inputParams[1];

                pairs[key] = value;

                inputLine = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine(); 

            pairs
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToList()
                .ForEach(x => Console.WriteLine("{0} <-> {1}", x.Key, x.Value));

            pairs
                .Where(x => x.Value == "null")
                .Select(x => x.Key + " <-> " + defaultValue) // Replaced with the default value.
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}