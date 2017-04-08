namespace _6.Stuck_Zipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var idealNumberOfDigits = CalculateIdealNumberOfDigits(firstList, secondList);

            RemoveNumberWithNonIdealNumbersOfDigits(firstList, idealNumberOfDigits);
            RemoveNumberWithNonIdealNumbersOfDigits(secondList, idealNumberOfDigits);

            var insertionIndex = 1;
            for (int i = 0; i < firstList.Count; i++)
            {
                var currentElement = firstList[i];
                secondList.Insert(Math.Min(insertionIndex, secondList.Count), currentElement);
                insertionIndex += 2;
            }

            Console.WriteLine(string.Join(" ", secondList));
        }

        private static void RemoveNumberWithNonIdealNumbersOfDigits(List<int> list, int idealNumberOfDigits)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentNumberOfDigits = CalculateNumberOfDigits(list[i]);
                if (currentNumberOfDigits > idealNumberOfDigits)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        private static int CalculateIdealNumberOfDigits(List<int> firstList, List<int> secondList)
        {
            var idealNumberOfDigits = int.MaxValue;

            foreach (var item in firstList)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);

                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }

            foreach (var item in secondList)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);

                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }

            return idealNumberOfDigits;
        }

        private static int CalculateNumberOfDigits(int number)
        {
            number = Math.Abs(number);

            var numberOfDigits = number.ToString().Length;

            // Faster code:

            //var numberOfDigits = 0;
            //while (number > 0)
            //{
            //    numberOfDigits++;
            //    number /= 10;
            //}

            return numberOfDigits;
        }
    }
}