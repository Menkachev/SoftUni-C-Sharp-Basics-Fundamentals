namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var shellbound = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var tokens = input.Split(' ');
                var regionName = tokens[0];
                var shells = int.Parse(tokens[1]);

                if (!shellbound.ContainsKey(regionName))
                {
                    shellbound[regionName] = new HashSet<int>();
                }

                shellbound[regionName].Add(shells);

                input = Console.ReadLine();
            }

            foreach (var item in shellbound)
            {
                var region = item.Key;
                var shell = item.Value;

                var sumOfShells = shell.Sum();
                var countOfShells = shell.Count();
                var giantShell = sumOfShells - (sumOfShells / countOfShells);

                Console.WriteLine($"{region} -> {string.Join(", ", shell)} ({giantShell})");
            }
        }
    }
}