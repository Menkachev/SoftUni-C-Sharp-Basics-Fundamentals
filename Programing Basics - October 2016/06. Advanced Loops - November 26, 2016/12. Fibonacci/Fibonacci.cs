namespace _12.Fibonacci
{
    using System;

    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            // Напишете програма, която въвежда цяло число n и пресмята n-тото число на Фибоначи.
            // Нулевото число на Фибоначи е 1, първото е също 1, а всяко следващо е сумата от 
            // предходните две. 

            var n = int.Parse(Console.ReadLine());

            var f0 = 1;
            var f1 = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var next = f0 + f1;
                f0 = f1;
                f1 = next;
            }

            Console.WriteLine(f1);
        }
    }
}