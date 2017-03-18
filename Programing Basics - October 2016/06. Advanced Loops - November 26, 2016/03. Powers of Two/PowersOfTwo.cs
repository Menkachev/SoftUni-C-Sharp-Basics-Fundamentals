namespace _03.Powers_of_Two
{
    using System;

    public class PowersOfTwo
    {
        // Напишете програма, която чете от конзолата цяло число n и печата числата от 1 до 2n. 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}