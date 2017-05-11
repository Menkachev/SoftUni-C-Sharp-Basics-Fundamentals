namespace _03.Fold_and_Sum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        // Read an array of 4 * k integers, fold it like shown below, and print the sum 
        // of the upper and lower two rows(each holding 2 * k integers).

        // Example: Input: 5 2 3 6 -> Output: 7 9    Comments: 5  6  +
        //                                                     2  3  =
        //                                                     7  9

        // NOT FINISHED //// NOT FINISHED //// NOT FINISHED ////

        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = nums.Length / 4;
            var foldLeft = new int[k];
            var foldRight = new int[k];

            for (int i = 0; i < k; i++)
            {
                foldLeft[i] = nums[nums.Length - 1 - i - 3 * k];
            }

            for (int i = 0; i < k; i++)
            {
                foldRight[i] = nums[nums.Length - 1 - i];
            }

            var folded = foldLeft.Concat(foldRight).ToArray();

            var sum = new int[2 * k];

            for (int i = k; i < nums.Length - k; i++)
            {
                sum[i - k] = nums[i] + folded[i - k];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}