namespace _07.Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        // Write a method that calculates all prime numbers in given range 
        // and returns them as list of integers.

        // Example: Input: 0; 10 -> Output: 2, 3, 5, 7

        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            var primesInRange = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", ", primesInRange));
        }

        // Find the prime numbers.
        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }

            return primes;
        }

        // Prime or not.
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