namespace Exercises___Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {

        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"([\w-.]+)\@([a-zA-Z-]+)(\.[\w-]+)+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                string matchString = match.ToString();

                if (!(matchString.StartsWith(".") || matchString.StartsWith("-") || matchString.StartsWith("_")
                    || (matchString.EndsWith(".") || matchString.EndsWith("-") || matchString.EndsWith("_"))))
                {
                    Console.WriteLine(matchString);
                }
            }
        }
    }
}