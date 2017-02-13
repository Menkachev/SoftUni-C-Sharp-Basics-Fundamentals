namespace Sunglasses
{
    using System;

    public class Sunglasses
    {
        //// Напишете програма, която въвежда цяло число "n" (3 ≤ n ≤ 100) и печата слънчеви очила 
        //// с размер 5 * n x n.

        ////  Example :  Input: 3 -> Output:  ******   ******
        ////                                  *////*|||*////*
        ////                                  ******   ******

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var starsRows = new string('*', n * 2) + new string(' ', n) + new string('*', n * 2);
            var middle = "*" + new string('/', (n * 2) - 2) + "*" + "*" +
                new string('/', (n * 2) - 2) + "*";
            
            Console.WriteLine(starsRows);

            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write("*");

                if (i == (n - 1) / 2)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write("*");
                Console.Write(new string('/', (n * 2) - 2));
                Console.WriteLine("*");
            }

            Console.WriteLine(starsRows);
        }
    }
}