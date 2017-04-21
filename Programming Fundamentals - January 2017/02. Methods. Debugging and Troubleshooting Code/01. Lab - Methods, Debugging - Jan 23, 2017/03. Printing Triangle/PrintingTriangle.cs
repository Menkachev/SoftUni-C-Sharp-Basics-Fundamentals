namespace _03.Printing_Triangle
{
    using System;
    public class PrintingTriangle
    {
        // Create a method for printing triangles.

        // Example: Input: 3 -> Output: 1
        //                              1 2
        //                              1 2 3
        //                              1 2
        //                              1
        public static void PrintTriangle(int number)
        {
            // Upper part
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", col);
                }

                Console.WriteLine();
            }

            // Bottom part
            for (int row = number - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", col);
                }

                Console.WriteLine();
            }
        }
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }
    }
}