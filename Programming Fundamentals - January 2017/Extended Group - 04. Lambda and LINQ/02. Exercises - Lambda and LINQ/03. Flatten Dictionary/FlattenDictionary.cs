namespace _03.Flatten_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine
                    .Split(' ')
                    .ToArray();

                if (inputParams[0] != "flatten")
                {
                    string key = inputParams[0];
                    string innerKey = inputParams[1];
                    string innerValue = inputParams[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }

                    if (!dictionary[key].ContainsKey(innerKey))
                    {
                        dictionary[key][innerKey] = innerKey;
                    }
                }
                else
                {
                    string key = inputParams[1];

                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flatten");
                }

                inputLine = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, string>> orderedDictionary = dictionary
                .OrderByDescending(d => d.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var key in orderedDictionary)
            {
                Console.WriteLine("{0}", key.Key);

                Dictionary<string, string> orderedInnerDictionary = key.Value
                    .Where(x => x.Value != "flatten")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string, string> flattenedValues = key.Value
                    .Where(x => x.Value == "flatten")
                    .ToDictionary(x => x.Key, x => x.Value);

                int counter = 1;
                foreach (var innerEntry in orderedInnerDictionary)
                {
                    Console.WriteLine("{0}. {1} - {2}", counter, innerEntry.Key, innerEntry.Value);
                    counter++;
                }

                foreach (var flatten in flattenedValues)
                {
                    Console.WriteLine("{0}. {1}", counter, flatten.Key);
                    counter++;
                }
            }
        }
    }
}