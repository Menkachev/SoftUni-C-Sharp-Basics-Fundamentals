namespace _02.Rotate_and_Sum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        // To “rotate an array on the right” means to move its last element first: 
        // {1, 2, 3} -> {3, 1, 2}.
        // Write a program to read an array of n integers(space separated on a single line) 
        // and an integer k, rotate the array right k times and sum the obtained arrays 
        // after each rotation.

        // Example: Input: 3 2 4 -1, 2 -> Output: 3 2 5 6

        // Comments: rotated1[] = -1  3  2  4, 
        //           rotated2[] =  4 -1  3  2, 
        //                sum[] =  3  2  5  6

        public static void Main()
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            var sum = new int[firstLine.Length];

            for (int i = 0; i < n; i++)
            {
                // Rotate an array on the right.
                var lastDigit = firstLine[firstLine.Length - 1]; 

                for (int j = firstLine.Length - 1; j > 0; j--)
                {
                    firstLine[j] = firstLine[j - 1]; 
                }

                firstLine[0] = lastDigit;

                // Sum the obtained arrays after each rotation. 
                for (int j = 0; j < firstLine.Length; j++)
                {
                    sum[j] += firstLine[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}