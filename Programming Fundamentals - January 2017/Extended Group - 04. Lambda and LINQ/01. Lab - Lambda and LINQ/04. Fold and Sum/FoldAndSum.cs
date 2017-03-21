namespace _04.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = nums.Length / 4;

            int[] leftPart = nums
                .Take(k)
                .Reverse()
                .ToArray();

            int[] rightPart = nums
                .Reverse()
                .Take(k)
                .ToArray();

            int[] upperRow = leftPart
                .Concat(rightPart)
                .ToArray();

            int[] lowRow = nums
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            int[] output = upperRow
                .Select((n, index) => n + lowRow[index])
                .ToArray();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}