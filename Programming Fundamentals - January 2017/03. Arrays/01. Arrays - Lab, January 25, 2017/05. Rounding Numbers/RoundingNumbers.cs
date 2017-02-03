namespace _05.Rounding_Numbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        //// Write a program to read an array of real numbers(space separated values), 
        //// round them to the nearest integer in “away from 0” style and print the output.

        //// Example: 

        //// Input: 0.9 1.5 2.4 

        //// Output: 0.9 => 1
        ////         1.5 => 2
        ////         2.4 => 2

        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}