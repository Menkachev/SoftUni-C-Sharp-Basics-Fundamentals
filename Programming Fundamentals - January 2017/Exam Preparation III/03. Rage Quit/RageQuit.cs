namespace _03.Rage_Quit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            var pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            StringBuilder outputResult = new StringBuilder();

            foreach (Match match in matches)
            {
                var message = match.Groups[1].Value.ToLower();
                var repeat = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < repeat; i++)
                {
                    outputResult.Append(message.ToUpper());
                }
            }

            Console.WriteLine("Unique symbols used: {0}", outputResult.ToString().Distinct().Count());
            Console.WriteLine(outputResult);
        }
    }
}