namespace _02.Max_Method
{
    using System;

    public class Program
    {
        // Create a method GetMax(int a, int b), that returns maximal of two numbers.
        // Write a program that reads three numbers from the console and prints 
        // the biggest of them. Use the GetMax(…) method you just created.

        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int maxNum = GetMax(firstNum, secondNum);
            int biggestNum = Math.Max(maxNum, thirdNum);

            Console.WriteLine(biggestNum);
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }
    }
}