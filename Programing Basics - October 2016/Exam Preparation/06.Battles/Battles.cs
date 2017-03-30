namespace _06.Battles
{
    using System;

    public class Battles
    {
        public static void Main(string[] args)
        {
            var player1 = int.Parse(Console.ReadLine());
            var player2 = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());

            var first = 0;
            var second = 0;
            var battles = 0;

            for (first = 1; first <= player1; first++)
            {
                for (second = 1; second <= player2; second++)
                {
                    if (battles >= maxBattles)
                    {
                        break;
                    }

                    Console.Write($" ({first} <-> {second}) ");
                    battles++;
                }
            }
        }
    }
}