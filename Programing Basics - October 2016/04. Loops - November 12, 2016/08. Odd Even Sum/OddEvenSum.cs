namespace _08.Odd_Even_Sum
{
    using System;

    public class OddEvenSum
    {
        //// Да се напише програма, която въвежда "n" цели числа и проверява дали сумата от числата 
        //// на четни позиции е равна на сумата на числата на нечетни позиции. При равенство да се 
        //// отпечата "Yes" + сумата; иначе да се отпечата "No" + разликата. Разликата се изчислява 
        //// по абсолютна стойност.

        //// Пример: Input: 4, 10(even position), 50(odd position), 60(even), 20(odd) -> Output: Yes, Sum = 70

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}