namespace _02.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        //// Write a program that extracts from a given sequence of words all elements that present 
        //// in it odd number of times (case-insensitive).

        ////   # Words are given in a single line, space separated.
        ////   # Print the result elements in lowercase, in their order of appearance.

        //// Example: Input: Java C# PHP PHP JAVA C java -> Output: java, c#, c

        public static void Main()
        {
            var simbols = Console.ReadLine().ToLower().Split(' ');

            var simbolsCount = new Dictionary<string, int>();

            //// The following code counts number of times each simbol/word appear in the input.

            foreach (var simbol in simbols)
            {
                if (!simbolsCount.ContainsKey(simbol))
                {
                    simbolsCount[simbol] = 0;
                }

                simbolsCount[simbol]++;
            }

            //// The following code extracts all simbols/words that appear odd number of times 
            //// and print them.

            var result = new List<string>();

            foreach (var item in simbolsCount)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}