namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        //// Write a program that extracts from a given text all palindromes, e.g.ABBA, lamal, exe 
        //// and prints them on the console on a single line, separated by comma and space. Use spaces, 
        //// commas, dots, question marks and exclamation marks as word delimiters. Print only unique 
        //// palindromes, sorted lexicographically.

        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            foreach (var word in text)
            {
                if (word == new string(word.Reverse().ToArray()))
                {
                    palindromes.Add(word);
                }
            }

        Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x => x)));
        }
    }
}