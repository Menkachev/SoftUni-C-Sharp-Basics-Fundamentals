namespace _10.Check_Prime
{
    using System;

    public class CheckPrime
    {
        // Напишете програма, която въвежда цяло число n и проверява дали е просто число
        // (дали се дели само на себе си и на единица). Да се отпечата “Prime” или “Not prime”. 

        public static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));
            var sqrt = (int)Math.Sqrt(n);
            bool isPrime = true;

            while (sqrt > 0)
            {
                    if (n % sqrt == 0)
                    {
                      isPrime = false;
                    }

                sqrt--;
            }

            if (isPrime == false || n == 0)
            {
                Console.WriteLine("Not prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}