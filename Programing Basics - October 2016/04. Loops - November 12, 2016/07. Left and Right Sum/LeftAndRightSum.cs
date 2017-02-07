namespace _07.Left_and_Right_Sum
{
    using System;

    public class LeftAndRightSum
    {
        //// Да се напише програма, която въвежда 2 * n цели числа и проверява дали сумата на първите 
        //// "n" числа (лява сума) е равна на сумата на вторите "n" числа (дясна сума). При равенство 
        //// печата "Yes" + сумата; иначе печата "No" + разликата. Разликата се изчислява като положително 
        //// число (по абсолютна стойност). 

        //// Пример: Input: 2, 10, 90, 60, 40 -> Output: Yes, sum = 100

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var count = n * 2;
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum += num;
            }

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}