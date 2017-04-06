namespace _01.Count_Work_Days
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class CountWorkDays
    {
        //// Write a program that reads two dates in format dd-MM-yyyy and prints the number of working 
        //// days between these two dates inclusive. Non-working days are:
        ////   # All days that are Saturday or Sunday.
        ////   # All days that are official holidays in Bulgaria:
        ////   - New Year Eve(1 Jan)
        ////   - Liberation Day(3 March)
        ////   - Worker’s day(1 May)
        ////   - Saint George’s Day(6 May)
        ////   - Saints Cyril and Methodius Day(24 May)
        ////   - Unification Day(6 Sept)
        ////   - Independence Day(22 Sept)
        ////   - National Awakening Day(1 Nov)
        ////   - Christmas(24, 25 and 26 Dec)
        //// All days not mentioned above are working and should count.

        public static void Main()
        {
            DateTime startDate = DateTime
                .ParseExact(
                Console.ReadLine()
                , "dd-MM-yyyy"
                , CultureInfo.InvariantCulture);

            DateTime endDate = DateTime
                .ParseExact(
                Console.ReadLine()
                , "dd-MM-yyyy"
                , CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            int workingDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DateTime checkDate = new DateTime(2016, currentDate.Month, currentDate.Day);

                if (currentDate.DayOfWeek != DayOfWeek.Saturday
                    && currentDate.DayOfWeek != DayOfWeek.Sunday
                    && !holidays.Contains(checkDate))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}