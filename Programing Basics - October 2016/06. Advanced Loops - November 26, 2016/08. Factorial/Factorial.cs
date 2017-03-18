namespace _08.Factorial
{
    using System;

    public class Factorial
    {
        // Напишете програма, която въвежда цяло число n (1 ≤ n ≤ 12) 
        // и изчислява и отпечатва n! = 1 * 2 * … * n (n факториел). 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fact = 1;

            do
            {
                fact = fact * n;
                n--;
            }
            while (n > 1);

            Console.WriteLine(fact);
        }
    }
}