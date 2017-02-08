namespace _01.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        //// Read a list of real numbers and print them in ascending order 
        //// along with their number of occurrences.

        //// Example: Input: 8 2.5 2.5 8 2.5 -> Output: 2.5 -> 3, 8 -> 2

        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse);

            var result = new SortedDictionary<double, int>();

            //// The following code counts number of times each simbol/word appear in the input.

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;
            }

            //// Prints numbers key and value on the console.

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}