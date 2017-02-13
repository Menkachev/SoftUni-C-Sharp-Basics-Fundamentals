namespace Triangle_of_Dollars
{
    using System;

    public class TriangleOfDollars
    {
        //// Да се напише програма, която въвежда число "n" и печата триъгълник от долари. 

        //// Example: Input: 5 -> Output: $
        ////                              $ $
        ////                              $ $ $
        ////                              $ $ $ $
        ////                              $ $ $ $ $

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");

                //// Print one more index in each row til gets equal with the index of "n".
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" $");
                }

                Console.WriteLine();
            }
        }
    }
}