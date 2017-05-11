namespace _05.Compare_Char_Arrays
{
    using System;
    using System.Linq;
    public class CompareCharArrays
    {
        // Compare two char arrays lexicographically(letter by letter).
        // Print the them in alphabetical order, each on separate line.

        public static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var arrays = new[] { new string(firstArr), new string(secondArr) };

            Console.WriteLine(string.Join("\n", arrays.OrderBy(arr => arr)));
        }
    }
}
