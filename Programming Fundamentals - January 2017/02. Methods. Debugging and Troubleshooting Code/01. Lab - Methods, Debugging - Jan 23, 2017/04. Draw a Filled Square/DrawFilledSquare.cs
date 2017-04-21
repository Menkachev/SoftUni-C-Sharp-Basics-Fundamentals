namespace _04.Draw_a_Filled_Square
{
    using System;

    public class DrawFilledSquare
    {
        // Draw at the console a filled square of size "n".

        // Example: Input: 4 -> Output:  --------
        //                               -\/\/\/-
        //                               -\/\/\/-
        //                               --------

        // Header row.
        public static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        // Middle row.
        public static void PrintMiddleRow(int n)
        {
            Console.Write("-");

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }

        // Print the result.
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderRow(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderRow(n);
        }
    }
}