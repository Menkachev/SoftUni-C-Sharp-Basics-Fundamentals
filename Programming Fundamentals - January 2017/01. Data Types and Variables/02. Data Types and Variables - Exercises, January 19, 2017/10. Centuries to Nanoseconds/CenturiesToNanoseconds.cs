namespace _10.Centuries_to_Nanoseconds
{
    using System;

    public class CenturiesToNanoseconds
    {
        //// Write program to enter an integer number of centuries and convert it to 
        //// years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.

        //// Example: Input: 1 -> Output: 1 centuries = 100 years = 36524 days = 876576 hours 
        ////                              = 52594560 minutes = 3155673600 seconds = 3155673600000 milliseconds 
        ////                              = 3155673600000000 microseconds = 3155673600000000000 nanoseconds

        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.Write("{0} centuries = {1} years = {2} days", centuries, years, days);
            Console.Write(" = {0} hours = {1} minutes = {2} seconds", hours, minutes, seconds);
            Console.WriteLine(" = {0} milliseconds = {1} microseconds = {2} nanoseconds", milliseconds, microseconds, nanoseconds);
        }
    }
}