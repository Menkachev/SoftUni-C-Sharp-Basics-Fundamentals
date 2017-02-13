namespace Rectangle_of_N_x_N_Stars
{
    using System;

    public class RectangleOfNxNStars
    {
        //// Напишете програма, която въвежда цяло положително число "n" и печата на конзолата правоъгълник 
        //// от n * n звездички.

        //// Example: Input: 4 -> Output:  ****
        ////                               ****
        ////                               ****
        ////                               ****

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}