namespace _06.Fold_and_Sum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        //// Read an array of 4 * k integers, fold it like shown below, and print the sum of the upper 
        //// and lower rows (2 * k integers).

        //// Example: Input: 1 2 3 4 5 6 7 8 -> Output: 5 5 13 13    Comments: 2  1  8  7  +
        ////                                                                   3  4  5  6  =
        ////                                                                   5  5 13 13
        
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            // Takes and reverse the "k" numbers from the left side
            var firstRowLeft = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            // Takes and reverse the "k" numbers from the right side
            var firstRowRight = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            // Split the "k" numbers from the left and the right side in one row
            var firstRow = firstRowLeft
                .Concat(firstRowRight)
                .ToArray();

            // Skips the "k" numbers from the input row
            var secondRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            // Finale result
            Console.WriteLine(
                string.Join(
                 " ", 
                firstRow
                .Zip(secondRow, (x, y) => x + y)
                .ToList()));
        }
    }
}