namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class Factorial
    {
        // Write a program that calculates and prints the "n!" for any "n" in the range[1…1000].

        // Example: Input: 5 -> Output: 120    Comments: 1 * 2 * 3 * 4 * 5 = 120

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

            Console.WriteLine(factorial);
        }
    }
}