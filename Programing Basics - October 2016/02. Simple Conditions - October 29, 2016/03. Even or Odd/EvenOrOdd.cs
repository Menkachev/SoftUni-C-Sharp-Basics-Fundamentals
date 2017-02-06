namespace Even_or_Odd
{
    using System;

    public class EvenOrOdd
    {
        //// Да се напише програма, която въвежда цяло число и печата дали е четно или нечетно.

        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
