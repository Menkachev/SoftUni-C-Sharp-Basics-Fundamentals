namespace _15.Fast_Prime_Checker
{
    using System;

    public class FastPrimeChecker
    {
        //// You are given a program that checks if numbers in a given range[2...N] are prime.
        //// For each number is printed "{number} is prime -> {True or False}". The code however, 
        //// is not very well written.Your job is to modify it in a way that is easy to read and understand.

        ////         int ___Do___ = int.Parse(Console.ReadLine());
        //// for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
        //// {    bool TowaLIE = true;
        ////          for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
        ////     {
        ////         if  (DAVIDIM % delio == 0)
        ////         {
        ////             TowaLIE = false;
        ////             break;
        ////         }
        //// }
        //// Console.WriteLine($"{DAVIDIM} is prime -> {TowaLIE}");

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool prime = true;
                for (int y = 2; y <= Math.Sqrt(i); y++)
                {
                    if (i % y == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}