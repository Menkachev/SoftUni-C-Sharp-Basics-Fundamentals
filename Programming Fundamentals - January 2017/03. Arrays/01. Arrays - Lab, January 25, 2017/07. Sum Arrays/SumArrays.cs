namespace _07.Sum_Arrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        //// Write a program that reads two arrays of integers and sums them.
        //// When the arrays are not of the same size, duplicate the smaller array a few times.

        //// Example:

        //// Input: 1 2 3 4 5 -> Output: 3 5 5 7 7   Comments: 1 2 3 4 5 +
        ////        2 3                                        2 3.2.3.2 =
        ////                                                   3 5 5 7 7

        public static void Main()
        {
            var firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var length = Math.Max(firstArray.Length, secondArray.Length);

            var sumOfArrays = new int[length];

            for (int i = 0; i < length; i++)
            {
                sumOfArrays[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ", sumOfArrays));
        }
    }
}