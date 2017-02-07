namespace _03.Latin_Letters
{
    using System;

    public class LatinLetters
    {
        //// Напишете програма, която отпечатва всички букви от латинската азбука: a, b, c, …, z.

        public static void Main()
        {
            Console.Write("Latin alphabet:");

            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(" " + letter);
            }

            Console.WriteLine();
        }
    }
}