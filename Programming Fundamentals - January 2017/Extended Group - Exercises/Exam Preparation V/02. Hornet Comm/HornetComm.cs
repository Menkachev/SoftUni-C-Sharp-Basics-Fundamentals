namespace Exercise_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class HornetComm
    {
        static void Main()
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "Hornet is Green")
            {
                var parts = inputLine
                    .Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (parts.Length != 2)
                {
                    continue;
                }

                var firstQuery = parts[0];
                var secondQuery = parts[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    string reversedQuery = new string(firstQuery.Reverse().ToArray());

                    messages.Add($"{reversedQuery} -> {secondQuery}");
                }
                else if (firstQuery.All(s => !char.IsDigit(s)) && secondQuery.All(char.IsLetterOrDigit))
                {
                    var transformed = new StringBuilder();

                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            transformed.Append(symbol.ToString().ToLower());
                        }
                        else if (char.IsLower(symbol))
                        {
                            transformed.Append(symbol.ToString().ToUpper());
                        }
                        else
                        {
                            transformed.Append(symbol);
                        }
                    }

                    broadcasts.Add($"{transformed} -> {firstQuery}");
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Any()
                ? string.Join(Environment.NewLine, broadcasts)
                : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any()
                ? string.Join(Environment.NewLine, messages)
                : "None");
        }
    }
}