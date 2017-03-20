namespace Diamond
{
    using System;

    public class Diamond
    {
        //// Напишете програма, която въвежда цяло число "n" (1 ≤ n ≤ 100) и печата диамант с размер n.

        //// Example: Input: 5 -> Output:  --*--        Input: 6 -> Output:  --**--
        ////                               -*-*-                             -*--*-
        ////                               *---*                             *----*
        ////                               -*-*-                             -*--*-
        ////                               --*--                             --**--

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int lineLeftRIght = (n - 2) / 2;
            int lineInside = n - (lineLeftRIght * 2) - 2;

            if (n % 2 == 0)
            {
                // Up Side To Middle.
                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine(
                        "{0}*{1}*{0}",
                        new string('-', lineLeftRIght),
                        new string('-', lineInside));

                    lineLeftRIght--;
                    lineInside += 2;
                }

                //Down.
                for (int i = n / 2; i > 0; i--)
                {
                    Console.WriteLine(
                        "{0}*{1}*{0}",
                        new string('-', lineLeftRIght),
                        new string('-', lineInside));

                    lineLeftRIght++;
                    lineInside -= 2;
                }
            }
            else
            {
                int lineLeftRightOdd = (n - 1) / 2; //Right "-" of diamond.
                int secondLinerightOrLeftOdd = (n - 2) / 2;
                int lineInsideOdd = n - (lineLeftRIght * 2) - 2;//"-" between stars in the middle.
                
                //Loop for up side.
                for (int i = 0; i < (n / 2); i++)
                {
                    //Check and print first line with one star.
                    if (i == 0)
                    {
                        Console.WriteLine("{0}{1}{0}",
                            new string('-', lineLeftRightOdd),
                            "*");

                        lineLeftRightOdd--;
                    }
                    //Print other lines to middle of diamond.
                    else
                    {
                        Console.WriteLine("{0}*{1}*{0}",
                            new string('-', lineLeftRightOdd),
                            new string('-', lineInsideOdd));

                        lineLeftRightOdd--;
                        lineInsideOdd += 2;
                    }

                }
                //Print down lines of diamond.
                for (int i = n / 2; i > 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', lineLeftRightOdd),
                        new string('-', lineInsideOdd));

                    lineLeftRightOdd++;
                    lineInsideOdd -= 2;
                }

                Console.WriteLine("{0}{1}{0}", new string('-', lineLeftRightOdd), "*");

            }
        }
    }
}