namespace _01.Min__Max__Sum__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxSumAverage
    {
        // Write a program to read n integers and print their sum, min, max, first, 
        // last and average values.

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currentN = int.Parse(Console.ReadLine());

                numbers.Add(currentN);
            }

            double sum = numbers.Sum();
            int min = numbers.Min();
            int max = numbers.Max();
            double average = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}