namespace _04.Largest_3_Numbers
{
    using System;
    using System.Linq;

    public class Largest3Numbers
    {
        //// Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, 
        //// print all of them.

        //// Example: Input: 10 30 15 20 50 5 -> Output: 50 30 20

        public static void Main()
        {
            Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}