namespace _02.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestThreeNumbers
    {
        // Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, 
        // print all of them.

        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var firstThreeLargest = nums
                .OrderByDescending(n => n)
                .Take(3);

            Console.WriteLine(string.Join(" ", firstThreeLargest));
        }
    }
}