namespace _01.Day_of_Week
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        //// You are given a date in format day-month-year. 
        //// Calculate and print the day of week in English.

        public static void Main()
        {
            var dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(
                dateAsString,
                "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}