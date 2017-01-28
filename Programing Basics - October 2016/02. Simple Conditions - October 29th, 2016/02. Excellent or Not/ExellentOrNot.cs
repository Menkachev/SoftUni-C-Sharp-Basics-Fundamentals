namespace Excellent_or_Not
{
    using System;

    public class ExellentOrNot
    {
        //// Да се напише конзолна програма, която въвежда оценка(десетично число) и отпечатва “Excellent!”, 
        //// ако оценката е 5.50 или по-висока, или “Not excellent.” в противен случай.

        public static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
