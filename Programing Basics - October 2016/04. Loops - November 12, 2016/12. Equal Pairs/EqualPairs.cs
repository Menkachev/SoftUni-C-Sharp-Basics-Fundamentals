namespace _12.Equal_Pairs
{
    using System;

    public class EqualPairs
    {
        //// Дадени са 2 * n числа. Първото и второто формират двойка, третото и четвъртото също и т.н. 
        //// Всяка двойка има стойност – сумата от съставящите я числа. Напишете програма, която проверява 
        //// дали всички двойки имат еднаква стойност или печата максималната разлика между две последователни 
        //// двойки. Ако всички двойки имат еднаква стойност, отпечатайте "Yes, value=…" + стойността. 
        //// В противен случай отпечатайте "No, maxdiff=…" + максималната разлика. 

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var number1 = double.Parse(Console.ReadLine());
            var number2 = double.Parse(Console.ReadLine());
            var sum = number1 + number2;

            var maxDiff = 0.0;

            for (int i = 1; i < n; i++)
            {
                var num1 = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                var sum2 = num1 + num2;

                if (!(sum == sum2))
                {
                    var diff = Math.Abs(sum - sum2);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

                sum = sum2;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}