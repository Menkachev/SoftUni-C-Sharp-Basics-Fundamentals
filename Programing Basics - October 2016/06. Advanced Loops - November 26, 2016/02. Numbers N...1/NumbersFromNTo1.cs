namespace Numbers_N._._._1
{
    using System;

    public class NumbersFromNTo1
    {
        // Напишете програма, която въвежда цяло положително число n и печата числата от 
        // n до 1 в обратен ред (от най-голямото към най-малкото). 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}