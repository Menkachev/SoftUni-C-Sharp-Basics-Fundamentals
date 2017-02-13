namespace House
{
    using System;

    public class House
    {
        //// Напишете програма, която въвежда число "n" (2 ≤ n ≤ 100) и печата къщичка с размер n x n.

        //// Example: Input: 5 -> Output:  --*--
        ////                               -***-
        ////                               *****
        ////                               |***|
        ////                               |***|

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            //// If "n" is even.
            if (n % 2 == 0)
            {
                //// Roof part.
                int rowSpace = (n / 2) - 1;
                int rowStar = 2;

                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(new string('-', rowSpace));
                    Console.Write(new string('*', rowStar));
                    Console.WriteLine(new string('-', rowSpace));
                    rowSpace--;
                    rowStar = rowStar + 2;
                }

                //// Bottom part.
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }
            else //// If "n" is odd.
            {
                //// Roof part.
                int rowSpace = (n - 1) / 2;
                int rowHouse = 1;

                for (int i = 0; i <= n / 2; i++)
                {
                    Console.Write(new string('-', rowSpace));
                    Console.Write(new string('*', rowHouse));
                    Console.WriteLine(new string('-', rowSpace));
                    rowSpace--;
                    rowHouse = rowHouse + 2;
                }

                //// Bottom part.
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }
        }
    }
}