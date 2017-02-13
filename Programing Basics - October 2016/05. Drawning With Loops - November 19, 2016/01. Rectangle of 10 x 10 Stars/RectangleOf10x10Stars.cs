namespace Rectangle_of_10_x_10_Stars
{
    using System;

    public class RectangleOf10x10Stars
    {
        //// Напишете програма, която чертае на конзолата правоъгълник от 10 x 10 звездички.

        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}