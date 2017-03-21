namespace _03.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        // Read a text, extract its words, find all short words (less than 5 characters) 
        // and print them alphabetically, in lowercase.

        // •	Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
        // •	Use case-insensitive matching.
        // •	Remove duplicated words.

        public static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(
                new[] 
                { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Select(w => w.ToLower())
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}