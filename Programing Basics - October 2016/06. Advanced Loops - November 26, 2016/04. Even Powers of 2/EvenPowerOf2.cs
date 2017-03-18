namespace _04.Even_Powers_of_2
{
    using System;

    public class EvenPowerOf2
    {
        // Да се напише програма, която въвежда n 
        // и печата четните степени на 2 ≤ 2n: 20, 22, 24, 28, …, 2n. 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num *= 2 * 2;
            }
        }
    }
}