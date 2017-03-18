namespace _05.Sequence_2k_1
{
    using System;

    public class Sequence2KPlus1
    {
        // Напишете програма, която въвежда число n и отпечатва всички числа ≤ n от редицата: 
        // 1, 3, 7, 15, 31, …. Всяко следващо число се изчислява като предишното число * 2 + 1. 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 1;

            while (sum <= n)
            {
                Console.WriteLine(sum);
                sum = sum * (2 + 1);
            }
        }
    }
}