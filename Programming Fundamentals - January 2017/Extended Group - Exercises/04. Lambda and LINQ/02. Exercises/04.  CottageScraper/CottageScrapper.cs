namespace _04.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScrapper
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<int>> treeTypesLength = new Dictionary<string, List<int>>();
            var input = Console.ReadLine();

            while (input != "chop chop")
            {
                var tokens = input
                    .Split(new[] { " ", "-", ">" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string tree = tokens[0];
                var length = int.Parse(tokens[1]);

                if (!treeTypesLength.ContainsKey(tree))
                {
                    treeTypesLength[tree] = new List<int>();
                }

                treeTypesLength[tree].Add(length);

                input = Console.ReadLine();
            }

            string typesOfTree = Console.ReadLine();
            var minLength = int.Parse(Console.ReadLine());

            var totalMeter = 0;
            var count = 0;

            foreach (var type in treeTypesLength.Values)
            {
                totalMeter += type.Sum();
                count += type.Count();
            }

            var pricePerMeter = Math.Round(totalMeter / (double)count, 2);

            List<int> tallerThanMinLength = new List<int>();

            foreach (var type in treeTypesLength)
            {
                if (type.Key == typesOfTree)
                {
                    tallerThanMinLength = type.Value
                        .Where(x => x >= minLength)
                        .ToList();
                }
            }

            var usedLogsPrice = Math.Round(tallerThanMinLength.Sum() * pricePerMeter, 2);

            List<int> unUsedLog = new List<int>();

            foreach (var type in treeTypesLength)
            {
                if (type.Key != typesOfTree)
                {
                    foreach (var item in type.Value)
                    {
                        unUsedLog.Add(item);
                    }
                }
                else
                {
                    foreach (var item in type.Value)
                    {
                        if (item < minLength)
                        {
                            unUsedLog.Add(item);
                        }
                    }
                }
            }

            var unUsedLogPrice = Math.Round(unUsedLog.Sum() * pricePerMeter * 0.25, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unUsedLogPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${(usedLogsPrice + unUsedLogPrice):F2}");
        }
    }
}