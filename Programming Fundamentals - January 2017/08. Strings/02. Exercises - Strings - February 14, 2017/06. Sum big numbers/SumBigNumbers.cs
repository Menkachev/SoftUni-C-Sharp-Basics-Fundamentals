namespace _06.Sum_big_numbers
{
    using System;
    using System.Linq;

    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine().ToList();
            var secondNum = Console.ReadLine().ToList();

            var sum = 0;

            //var min = Math.Min(firstNum, secondNum);
            //var max = Math.Max(firstNum, secondNum);

            for (int i = firstNum.Count; i < secondNum.Count; i++)
            {
                sum = firstNum[firstNum.Count - 1 -i] + secondNum[secondNum.Count -1 - i];
            }

            Console.WriteLine(sum);
        }
    }
}