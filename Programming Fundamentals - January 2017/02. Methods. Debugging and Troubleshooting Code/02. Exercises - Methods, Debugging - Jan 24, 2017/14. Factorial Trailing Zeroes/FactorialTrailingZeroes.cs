namespace _14.Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        // Create a program that counts the trailing zeroes of the factorial of a given number.

        // Example: Input: 5 -> Output: 1   Comments: 5! = 120 -> One trailing zero 

        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            do
            {
                factorial = factorial * number;
                number--;
            }
            while (number > 1);

            var zeros = CountTrailingZeros(number, factorial);

            Console.WriteLine(zeros);
        }

        // Trailing zeros.
        private static int CountTrailingZeros(int number, BigInteger factorial)
        {
            var stringFact = factorial.ToString();

            var counter = 0;

            for (int i = 0; i < stringFact.Length; i++)
            {
                var currentNum = factorial % 10;

                if (currentNum == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }

                factorial /= 10;
            }

            return counter;
        }
    }
}