namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        //// Read a list of integers and extract all square numbers from it 
        //// and print them in descending order.A square number is an integer which 
        //// is the square of any integer. For example, 1, 4, 9, 16 are square numbers.

        //// Example: Input: 3 16 4 5 6 8 9  -> Output: 16 9 4

        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            var squareNumbers = new List<int>();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = (int)numbers[i];
                var square = Math.Sqrt(currentNumber);

                if (square == (int)square)
                {
                    Console.Write(numbers[i] + " ");
                }

                ////squareNumbers.Sort((a, b) => b.CompareTo(a));

                ////Console.WriteLine(string.Join(" ", squareNumbers));
            }
        }
    }
}