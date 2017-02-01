namespace _06.Triples_of_Letters
{
    using System;

    public class TriplesOfLetters
    {
        //// Write a program to read an integer "n" and print all triples of the first "n" 
        //// small Latin letters, ordered alphabetically.

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 < number; i1++)
            {
                for (int i2 = 0; i2 < number; i2++)
                {
                    for (int i3 = 0; i3 < number; i3++)
                    {
                        char letter1 = (char)('a' + i1);
                        char letter2 = (char)('b' + i2 - 1);
                        char letter3 = (char)('c' + i3 - 2);

                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }
            }
        }
    }
}