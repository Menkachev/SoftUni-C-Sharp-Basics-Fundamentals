namespace _10.Half_Sum_Element
{
    using System;

    public class HalfSumElement
    {
        //// Да се напише програма, която въвежда "n" цели числа и проверява дали сред тях съществува число, 
        //// което е равно на сумата на всички останали. Ако има такъв елемент, печата "Yes" + неговата 
        //// стойност; иначе печата "No" + разликата между най-големия елемент и сумата на останалите 
        //// (по абсолютна стойност). 

        //// Пример: Input: 4, 6, 1, 2, 3 -> Output: Yes, Sum 6    Comments: 1 + 2 + 3 = 6

        public static void Main()
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxNumber = int.MinValue;
            var difference = sum - maxNumber;

            for (int i = 0; i < numbersCount; i++)
            {
                var number = int.Parse(Console.ReadLine());

                sum = sum + number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            if ((sum - maxNumber) == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs((sum - maxNumber) - maxNumber));
            }
        }
    }
}