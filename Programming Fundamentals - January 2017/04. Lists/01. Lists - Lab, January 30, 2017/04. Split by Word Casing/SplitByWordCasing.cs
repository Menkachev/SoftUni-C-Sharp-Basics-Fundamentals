namespace _04.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        //// Read a text, split it into words and distribute them into 3 lists.

        ////    "Lower-case" words like “programming”, “at” and “databases” – consist of lowercase letters only.
        ////    "Mixed-case" words like “C#”, “SoftUni” and “Java” – all others.
        ////    "Upper-case" words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.

        //// Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space

        public static void Main()
        {
            //// Separators: , ; : . ! ( ) " ' \ / [ ]

            char[] separators =
            {
                ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' '
            };

            string[] text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixCaseWords = new List<string>();

            foreach (var word in text)
            {
                if (word.All(char.IsLower))
                {
                    lowerCaseWords.Add(word);
                }
                else if (word.All(char.IsUpper))
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixCaseWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}