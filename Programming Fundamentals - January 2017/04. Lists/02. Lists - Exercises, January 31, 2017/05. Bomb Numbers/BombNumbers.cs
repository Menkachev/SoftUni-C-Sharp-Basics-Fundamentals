namespace _05.Bomb_Numbers
{
    using System;
    using System.Linq;

    public class BombNumbers
    {
        //// Write a program that reads sequence of numbers and special bomb number with a certain power.
        //// Your task is to detonate every occurrence of the special bomb number and according to its power 
        //// his neighbors from left and right. Detonations are performed from left to right and all detonated 
        //// numbers disappear. Finally print the sum of the remaining elements in the sequence.

        //// Example: Input: 1 2 2 4 2 2 2 9, 4 2 -> Output: 12    Comments: Special number is 4 with power 2. 
        ////                                                       After detontaion we left with the sequence
        ////                                                       [1, 2, 9] with sum 12.

        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

            var specialNumber = bomb[0];
            var power = bomb[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber == specialNumber)
                {
                    var leftSide = Math.Max(i - power, 0);
                    var rightSide = Math.Min(i + power, numbers.Count - 1);

                    numbers.RemoveRange(i, rightSide - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftSide, i - leftSide);
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}