namespace _05.Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        //// Read a text, extract its words, find all short words (less than 5 characters) and print them 
        //// alphabetically, in lowercase.

        ////   # Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
        ////   # Use case-insensitive matching.
        ////   # Remove duplicated words.

        public static void Main()
        {
            Console.WriteLine(
                string.Join(
                ", ",
                Console.ReadLine()
                .ToLower()
                .Split(
                new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToList()));
        }
    }
}