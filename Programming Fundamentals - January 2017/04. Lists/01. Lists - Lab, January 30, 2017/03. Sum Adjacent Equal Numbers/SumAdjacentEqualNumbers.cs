namespace _03.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        //// Write a program to sum all adjacent equal numbers in a list of decimal numbers, 
        //// starting from left to right.
        ////    After two numbers are summed, the obtained result could be equal to some of its neighbors 
        ////    and should be summed as well. Always sum the leftmost two equal neighbors
        ////    (if several couples of equal neighbors are available).
        
        //// Example: Input: 3 3 6 1 -> Output: 12 1 (3 + 3 6 1 -> 6 6 1 -> 6 + 6  1 -> 12 1)

        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    numbers[i - 1] += numbers[i];
                    numbers.RemoveAt(i);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
