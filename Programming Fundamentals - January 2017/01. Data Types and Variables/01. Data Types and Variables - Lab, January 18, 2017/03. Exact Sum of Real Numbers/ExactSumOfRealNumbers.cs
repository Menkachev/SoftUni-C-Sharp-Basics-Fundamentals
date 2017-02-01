namespace _03.Exact_Sum_of_Real_Numbers
{
    using System;

    public class ExactSumOfRealNumbers
    {
        //// Write program to enter n numbers and calculate and print their exact sum(without rounding).

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < number; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}