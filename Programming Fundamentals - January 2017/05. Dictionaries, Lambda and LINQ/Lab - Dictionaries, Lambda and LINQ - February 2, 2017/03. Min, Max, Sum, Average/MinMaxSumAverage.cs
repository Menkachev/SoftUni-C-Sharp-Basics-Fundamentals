namespace _03.Min__Max__Sum__Average
{
    using System;
    using System.Linq;

    public class MinMaxSumAverage
    {
        //// Write a program to read "n" integers and print their sum, min, max, first, last and 
        //// average values.

        //// Example: Input: 5, 12, 20, -5, 37, 8, -> Output: Sum = 72, Min = -5, Max = 37, Average = 14.4

        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var numbers = new int[num];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}