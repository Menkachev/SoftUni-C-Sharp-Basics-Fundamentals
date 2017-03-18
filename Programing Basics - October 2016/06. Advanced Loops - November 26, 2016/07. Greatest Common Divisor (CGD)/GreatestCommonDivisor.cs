namespace _07.Greatest_Common_Divisor__CGD_
{
    using System;

    public class GreatestCommonDivisor
    {
        // Напишете програма, която въвежда две цели положителни числа a и b и изчислява 
        // и отпечатва най-големият им общ делител (НОД). 

        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            Console.WriteLine(a);
        }
    }
}