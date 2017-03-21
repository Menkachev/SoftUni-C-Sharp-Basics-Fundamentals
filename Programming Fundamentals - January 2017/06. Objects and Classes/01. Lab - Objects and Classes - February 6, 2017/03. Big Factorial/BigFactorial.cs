namespace _03.Big_Factorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        //// Calculate and print n! (n factorial) for very big integer n (e.g. 1000).

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger result = 1; 

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}