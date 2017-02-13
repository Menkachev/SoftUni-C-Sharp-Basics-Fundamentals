namespace Square_of_Stars
{
    using System;

    public class SquareOfStars
    {
        //// Напишете програма, която чете от конзолата число "n" и чертае квадрат от n * n звездички,
        //// като между всеки две звездички има по един интервал.

        //// Example: Input: 4 -> Output:  * * * *
        ////                               * * * *
        ////                               * * * *
        ////                               * * * *

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");

                //// Nested loop which contains space and star.
                for (int j = 1; j < n; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}