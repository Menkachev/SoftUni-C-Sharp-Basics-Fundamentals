namespace Christmas_Tree
{
    using System;

    public class ChristmasTree
    {
        //// Напишете програма, която въвежда число "n" (1 ≤ n ≤ 100) и печата коледна елха с размер n.

        //// Example: Input: 3 -> Output:     |
        ////                                * | *
        ////                               ** | **
        ////                              *** | ***

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                var spaces = new string(' ', n - i);
                var stars = new string('*', i);

                Console.Write(spaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.WriteLine(spaces);
            }
        }
    }
}