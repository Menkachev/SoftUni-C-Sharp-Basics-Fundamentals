namespace Extended___Objects_and_Simple_Classes
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        // You are given a date in format day-month-year. 
        // Calculate and print the day of week in English.

        public static void Main()
        {
            string dayAsText = Console.ReadLine();

            DateTime date = DateTime
                .ParseExact(dayAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}