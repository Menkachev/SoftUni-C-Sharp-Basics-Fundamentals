namespace Rhombus_of_Stars
{
    using System;

    public class RhombusOfStars
    {
        //// Напишете програма, която въвежда цяло положително число "n" 
        //// и печата ромбче от звездички с размер n.

        //// Example: Input: 3 -> Output:  *
        ////                              * *
        ////                             * * *
        ////                              * *
        ////                               *

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            //// Upper part.
            for (int i = 1; i <= n; i++)
            {
                var line = new string(' ', n - i) + "*";

                for (int j = 1; j < i; j++)
                {
                    line = line + " *";
                }

                Console.WriteLine(line);
            }

            //// Bottom part. Invert the upper part's loop.
            for (int i = n - 1; i > 0; i--)
            {
                var line = new string(' ', n - i) + "*";

                for (int j = 1; j < i; j++)
                {
                    line = line + " *";
                }

                Console.WriteLine(line);
            }
        }
    }
}