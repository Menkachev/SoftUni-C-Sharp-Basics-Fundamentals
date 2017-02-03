namespace _14.Integer_to_Hex_and_Binary
{
    using System;

    public class IntegerToHexAndBinary
    {
        //// Create a program to convert a decimal number to hexadecimal and binary number and print it.

        //// Example: Input: 420 -> Output: 1A4, 110100100

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 16).ToUpper());
            Console.WriteLine(Convert.ToString(number, 2).ToUpper());
        }
    }
}