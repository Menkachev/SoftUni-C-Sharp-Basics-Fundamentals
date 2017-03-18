namespace _06.Number_in_Range__1._._._100_
{
    using System;

    public class NumbersInRange1To100
    {
        // Напишете програма, която въвежда цяло положително число n в диапазона [1…100]. 
        // При въвеждане на число извън посочения диапазон, да се отпечата съобщение за 
        // грешка и потребителят да се подкани да въведе ново число. 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                Console.WriteLine("Enter a number in the range [1...100]:");
                Console.WriteLine("Invalid number!");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is {0}", n);
        }
    }
}