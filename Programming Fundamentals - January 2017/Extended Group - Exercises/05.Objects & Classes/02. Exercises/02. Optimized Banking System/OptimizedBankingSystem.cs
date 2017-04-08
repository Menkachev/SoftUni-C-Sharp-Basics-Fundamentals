namespace _02.Optimized_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OptimizedBankingSystem
    {
        public static void Main(string[] args)
        {
            List<BankAccount> bankingSystem = new List<BankAccount>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine
                    .Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string bank = inputParams[0];
                string accountName = inputParams[1];
                decimal accountBalance = decimal.Parse(inputParams[2]);

                BankAccount newBankAccount = new BankAccount();
                newBankAccount.Bank = bank;
                newBankAccount.Name = accountName;
                newBankAccount.Balance = accountBalance;

                bankingSystem.Add(newBankAccount);

                inputLine = Console.ReadLine();
            }

            foreach (var account in bankingSystem
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }
    }
}