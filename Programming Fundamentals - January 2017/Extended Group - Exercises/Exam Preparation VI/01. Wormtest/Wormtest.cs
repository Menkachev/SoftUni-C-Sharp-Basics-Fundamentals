namespace Problem_1
{
    using System;
    public class Wormtest
    {
        public static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var lengthInCm = length * 100;
            var reminder = lengthInCm % width;

            if (reminder == 0 || reminder < 0)
            {
                Console.WriteLine("{0:F2}", lengthInCm * width);
            }
            else
            {
                Console.WriteLine("{0:F2}%", (lengthInCm / width) * 100);
            }
        }
    }
}
