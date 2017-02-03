namespace _11.Convert_Speed_Units
{
    using System;

    public class ConvertSpeedUnits
    {
        //// Create a program to ask the user for a distance(in meters) and the time taken
        //// (as three numbers: hours, minutes, seconds), and print the speed, in meters per second, 
        //// kilometers per hour and miles per hour.  
        //// Every number in the output should be precise up to 6 digits after the floating point.
        //// Assume 1 mile = 1609 meters.

        //// Example: Input: 1000 -> Output: 0.2732241
        ////                 1               0.9836066
        ////                 1               0.6113155
        ////                 0


        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            var time = (hours * 3600) + (minutes * 60) + seconds;

            float metersPerSeconds = (float)distanceInMeters / time;
            float kilometersPerHour = ((float)distanceInMeters / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distanceInMeters / 1609) / ((float)time / 3600);

            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}