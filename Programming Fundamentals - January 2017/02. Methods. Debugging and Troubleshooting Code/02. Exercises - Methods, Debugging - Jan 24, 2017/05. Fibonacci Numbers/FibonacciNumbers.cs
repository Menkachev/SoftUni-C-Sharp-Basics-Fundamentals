namespace _05.Fibonacci_Numbers
{
    using System;

    public class FibonacciNumbers
    {
        // Define a method Fib(n) that calculates the nth Fibonacci number.

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int showFibNum = Fibonacci(n);

            Console.WriteLine(showFibNum);
        }

        private static int Fibonacci(int n)
        {
            var f0 = 1;
            var f1 = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var nextF = f0 + f1;
                f0 = f1;
                f1 = nextF;
            }

            return f1;
        }
    }
}