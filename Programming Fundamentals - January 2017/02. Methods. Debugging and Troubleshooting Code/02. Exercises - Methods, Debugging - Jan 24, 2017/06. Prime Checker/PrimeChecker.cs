namespace _06.Prime_Checker
{
    using System;

    public class PrimeChecker
    {
        // Write a Boolean method IsPrime(n) that check 
        // whether a given integer number "n" is prime.

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            bool primeOrNotPrime = IsPrime(n);

            Console.WriteLine(primeOrNotPrime);
        }

        private static bool IsPrime(long number)
        {
            bool prime = true;

            if (number <= 1)
            {
                prime = false;

                return prime;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }

            return prime;
        }
    }
}