namespace _04.Sum_Numbers
{
    using System;

    public class SumNumbers
    {
        //// Да се напише програма, която въвежда "n" цели числа и ги сумира.
        ////   # От първия ред на входа се въвежда броят числа "n".
        ////   # От следващите "n" реда се въвежда по едно цяло число.
        //// Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. 

        //// Пример: Input: 2, 10, 20 -> Output: 30

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine("sum = {0}", sum);
        }
    }
}