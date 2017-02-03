namespace _05.Special_Numbers
{
    using System;

    public class SpecialNumbers
    {
        //// A number is special when its sum of digits is 5, 7 or 11.
        //// Write a program to read an integer "n" and for all numbers in the range 1…n 
        //// to print the number and if it is special or not (True / False).

        //// Example: Input: 5 -> Output: 1 -> False, 2 -> False, 3 -> False, 4 -> False, 5 -> True

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 1; num <= number; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10; // Remains the last digit then sum it with the next one.
                    digits = digits / 10; // Remove the last digit.
                }

                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine("{0} -> {1}", num, special);
            }
        }
    }
}
