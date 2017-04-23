namespace _01.Match_full_name
{
    using System;
    using System.Text.RegularExpressions;
    public class MatchFullName
    {
         // Write a regular expression to match a valid full name. A valid full name consists of two words, 
         // each word starts with a capital letter and contains only lowercase letters afterwards; 
         // each word should be at least two letters long; the two words should be separated by a single space.

        public static void Main(string[] args)
        {
            string names = Console.ReadLine();

            var pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            foreach (var match in regex.Matches(names))
            {
                Console.WriteLine(match);
            }
        }
    }
}
