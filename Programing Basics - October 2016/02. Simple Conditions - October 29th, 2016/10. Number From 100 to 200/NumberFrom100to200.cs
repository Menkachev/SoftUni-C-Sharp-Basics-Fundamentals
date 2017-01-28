namespace Number_100._._._200
{
    using System;

    public class NumberFrom100To200
    {
        //// Да се напише програма, която въвежда цяло число и проверява дали е под 100, между 100 и 200 или над 200.

        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number <= 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (100 <= number && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (number >= 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}