namespace _06.Min_Number
{
    using System;

    public class MinNumber
    {
        //// Напишете програма, която въвежда "n" цели числа(n > 0) и намира най-малкото измежду тях.
        //// Първо се въвежда броят числа "n", а след това самите "n" числа, по едно на ред.

        //// Пример: Input: 3, -10, 20, -30 -> Output: -30

        public static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());
            var smallest = int.MaxValue;

            for (int i = 0; i < numberCount; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}