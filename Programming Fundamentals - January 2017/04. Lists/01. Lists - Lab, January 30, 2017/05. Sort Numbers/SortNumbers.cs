namespace _05.Sort_Numbers
{
    using System;
    using System.Linq;

    public class SortNumbers
    {
        //// Read a list of decimal numbers and sort them in increasing order.
        //// Example: Input: 8 25 2 11 -> Output: 2 <= 8 <= 11 <= 25

        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
