namespace _04.Sum_Reversed_Numbers
{
    using System;
    using System.Linq;

    public class SumReversedNumbers
    {
        //// Write a program that reads sequence of numbers, reverses their digits, and prints their sum.

        //// Example: Input: 123 234 12 -> Output: 774   Comments: 321 + 432 + 21 = 774

        public static void Main()
        {
            var numbers = Console.ReadLine().Split();

            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                var reversed = string.Join("", currentNumber.Reverse());

                var intNumber = int.Parse(reversed);

                sum = sum + intNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
