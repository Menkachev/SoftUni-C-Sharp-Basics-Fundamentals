namespace _11.Equal_Sums
{
    using System;
    using System.Linq;
    public class EqualSums
    {
        // Write a program that determines if there exists an element in the array such that the sum 
        // of the elements on its left is equal to the sum of the elements on its right. If there are 
        // no elements to the left / right, their sum is considered to be 0. Print the index that 
        // satisfies the required condition or “no” if there is no such index.
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var leftSum = 0;
            var rightSum = 0;
            var isEqual = false; // This bool is for the answer "no" on the console.

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true; // This will keep the answer outside of the nested loop.
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (!isEqual) // If you don't use this bool and the sums aren't equal, you'll receive empty spase on the console.
            {
                Console.WriteLine("no");
            }
        }
    }
}
