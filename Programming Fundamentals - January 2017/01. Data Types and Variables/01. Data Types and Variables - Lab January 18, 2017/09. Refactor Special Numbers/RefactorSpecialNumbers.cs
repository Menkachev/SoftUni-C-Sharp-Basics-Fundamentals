namespace _09.Refactor_Special_Numbers
{
    using System;

    public class RefactorSpecialNumbers
    {


        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;
            int digits = 0;
            bool special = false;

            for (int num = 1; num <= number; num++)
            {
                digits = num;
                while (num > 0)
                {
                    sumOfDigits += num % 10; // Remains the last digit then sum it with the next one.
                    num = num / 10; // Remove the last digit.
                }

                special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{digits} -> {special}");
                sumOfDigits = 0;
                num = digits;
            }
        }
    }
}