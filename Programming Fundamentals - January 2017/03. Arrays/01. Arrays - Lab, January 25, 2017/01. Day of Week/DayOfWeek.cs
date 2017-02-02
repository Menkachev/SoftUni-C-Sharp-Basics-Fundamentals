namespace _01.Day_of_Week
{
    using System;

    public class DayOfWeek
    {
        //// Enter a day number[1…7] and print the day name(in English) or “Invalid Day!”. 
        //// Use an array of strings.

        public static void Main()
        {
            var daysOfWeek = new string[]
                {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
                };

            var day = int.Parse(Console.ReadLine());

            if (day <= 0 || day > 7)
            {
                Console.WriteLine("Invalid Day");
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
        }
    }
}