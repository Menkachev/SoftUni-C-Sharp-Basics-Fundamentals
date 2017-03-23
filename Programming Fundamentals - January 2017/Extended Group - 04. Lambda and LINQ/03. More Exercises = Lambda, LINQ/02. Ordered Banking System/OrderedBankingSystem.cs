namespace _02.Ordered_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBankingSystem
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> bankingSystem = new Dictionary<string, Dictionary<string, decimal>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string bank = tokens[0];
                string account = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (!bankingSystem.ContainsKey(bank))
                {
                    bankingSystem.Add(bank, new Dictionary<string, decimal>());
                }

                if (!bankingSystem[bank].ContainsKey(account))
                {
                    bankingSystem[bank].Add(account, 0); // 0 for initial value for the balance.
                }

                bankingSystem[bank][account] += balance; // Keep and collect each balance per account.

                inputLine = Console.ReadLine();
            }

             bankingSystem
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value)) //BANKS by the sum of all account balances.
                .ThenByDescending(bank => bank.Value.Max(account => account.Value)) //The bank with the highest maximum balance in its accounts.
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(account => account.Value) // Bank’s accounts ordered in descending order, by their balance.
                .ToList()
                .ForEach(account => Console.WriteLine(
                    "{0} -> {1} ({2})", 
                account.Key, 
                account.Value, 
                bank.Key)));
        }
    }
}