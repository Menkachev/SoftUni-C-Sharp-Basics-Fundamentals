namespace _4.Sieve_of_Eratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        //// Write a program to find all prime numbers in range[1…n]. 
        //// Implement the algorithm called “Sieve of Eratosthenes”.

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 2; i <= n; i++)
            {
                if (primes[i] == true)
                {
                    Console.WriteLine(i);

                    for (int j = 2; j <= n; j++)
                    {
                        if (j * i <= n && j * i >= 0)
                        {
                            primes[j * i] = false;
                        }
                    }
                }
            }
        }
    }
}