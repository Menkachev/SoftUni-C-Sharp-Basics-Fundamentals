namespace _09.Sum_Digits
{
    using System;

    public class SumDigits
    {
        // Напишете програма, която въвежда цяло число num и отпечатва сумата от цифрите му.

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;

            do
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            while (n > 0);
            Console.WriteLine(sum);
        }
    }
}