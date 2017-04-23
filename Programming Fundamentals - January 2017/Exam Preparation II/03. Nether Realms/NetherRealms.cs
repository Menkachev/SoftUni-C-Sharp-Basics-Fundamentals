namespace _03.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse)
                .OrderBy(a => a.Name)
                .ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }

    public class Demon
    {
        public string Name { get; set; }

        public decimal Health { get; set; }

        public decimal Damage { get; set; }

        public static Demon Parse(string demonName)
        {
            var demon = new Demon();

            demon.Name = demonName;

            demon.Health = CalculateHealth(demonName);
            demon.Damage = CalculateDamage(demonName);

            return demon;
        }

        private static decimal CalculateDamage(string demonName)
        {
            var damageNumberPattern = @"[+-]?\d+(?:\.?\d+)?";

            var damageNumbers = Regex.Matches(demonName, damageNumberPattern);
            var damageSum = 0m;

            foreach (Match match in damageNumbers)
            {
                damageSum += decimal.Parse(match.Value);
            }

            var modifiers = demonName
                .Where(a => a == '*' || a == '/')
                .ToArray();

            foreach (var modifier in modifiers)
            {
                switch (modifier)
                {
                    case '*':
                        damageSum *= 2;
                        break;
                    case '/':
                        damageSum /= 2;
                        break;
                }
            }

            return damageSum;
        }

        private static decimal CalculateHealth(string demonName)
        {
            var healthPattern = @"[^0-9+\-*\/\.]";

            var healthChars = Regex.Matches(demonName, healthPattern);

            var healthValues = new List<decimal>();

            foreach (Match match in healthChars)
            {
                healthValues.Add(char.Parse(match.Value));
            }

            var health = healthValues.Sum();

            return health;
        }
    }
}