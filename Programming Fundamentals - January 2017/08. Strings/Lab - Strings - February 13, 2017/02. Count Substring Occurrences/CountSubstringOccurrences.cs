namespace _02.Count_Substring_Occurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        //// Write a program to find how many times a given string appears in a given text as substring.
        //// The text is given at the first input line.The search string is given at the second input line. 
        //// The output is an integer number. Please ignore the character casing. 
        //// Overlapping between occurrences is allowed.

        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var index = 0;
            var count = 0;

            while (true)
            {
                var found = text.IndexOf(pattern, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}