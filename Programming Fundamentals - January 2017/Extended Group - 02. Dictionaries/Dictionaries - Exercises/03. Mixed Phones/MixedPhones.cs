namespace _03.Mixed_Phones
{
    using System;
    using System.Collections.Generic;

    public class MixedPhones
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var phoneNumbers = new SortedDictionary<string, decimal>();

            while (line != "Over")
            {
                var tokens = line
                    .Split(" : ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                var phoneNumber = 0m;
                if (decimal.TryParse(firstElement, out phoneNumber))
                {
                    phoneNumbers[secondElement] = phoneNumber;
                }
                else if (decimal.TryParse(secondElement, out phoneNumber))
                {
                    phoneNumbers[firstElement] = phoneNumber;
                }

                line = Console.ReadLine();
            }

            foreach (var pair in phoneNumbers)
            {
                var name = pair.Key;
                var phoneNumber = pair.Value;

                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}