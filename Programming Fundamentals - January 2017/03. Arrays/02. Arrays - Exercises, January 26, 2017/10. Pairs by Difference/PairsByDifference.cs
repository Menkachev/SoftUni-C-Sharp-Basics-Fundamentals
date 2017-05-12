namespace _10.Pairs_by_Difference
{
    using System;
    using System.Linq;
    public class PairsByDifference
    {
        // Write a program that count the number of pairs in given array which difference 
        // is equal to given number.

        // Input: 1 5 3 4 2    Output: 3    Comment: Pairs of elements with difference 2 -> {1, 3}, {5, 3}, {4, 2}
        //        2

        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    var sum = numbers[i] - numbers[j];

                    if (sum == difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
