namespace _05.Max_Number
{
    using System;

    public class MaxNumber
    {
        //// Напишете програма, която въвежда "n" цели числа(n > 0) и намира най-голямото измежду тях.
        //// Първо се въвежда броят числа "n", а след това самите "n" числа, по едно на ред.

        //// Пример: Input: 3, -10, 20, -30 -> Output: 20

        public static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());
            var max = int.MinValue;

            for (int i = 0; i < numberCount; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine(max);
        }
    }
}