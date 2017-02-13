namespace Square_Frame
{
    using System;

    public class SquareFrame
    {
        //// Напишете програма, която въвежда цяло положително число "n" и чертае на конзолата 
        //// квадратна рамка с размер n * n.

        //// Example: Input: 4 -> Output:  + - - +
        ////                               | - - |
        ////                               | - - |
        ////                               + - - +

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            //// Upper part.

            //// First symbol from the coll.
            Console.Write("+");

            //// Loop for the middle part of the coll.
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }

            //// Last symbol from the coll.
            Console.WriteLine(" +");

            //// Middle part.
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");

                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }

                Console.WriteLine(" |");
            }

            //// Bottom part(the same like the upper).
            Console.Write("+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }

            Console.WriteLine(" +");
        }
    }
}