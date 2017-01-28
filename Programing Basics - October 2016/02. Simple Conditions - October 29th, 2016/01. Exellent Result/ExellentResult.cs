namespace Exellent_Result
{
    using System;

    public class ExellentResult
    {
        //// Да се напише конзолна програма, която въвежда оценка(десетично число) 
        //// и отпечатва “Excellent!”, ако оценката е 5.50 или по-висока.

        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
