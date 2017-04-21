namespace _04.Numbers_in_Reversed_Order
{
    using System;

    public class NumbersInReversedOrder
    {
        // Write a method that prints the digits of a given decimal number in a reversed order.

        // Example: Inpu: 1.12 -> Output: 21.1

        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(num));
        }

        private static double ReversedNum(double num)
        {
            // Convert from double to string.
            var numToString = num.ToString();

            // Start with an empty string.
            var reversedString = string.Empty;

            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                reversedString += numToString[i];
            }

            // Convert the string back to double.
            var reversedNum = double.Parse(reversedString);

            return reversedNum;
        }
    }
}