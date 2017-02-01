namespace _11.Convert_Speed_Units
{
    using System;

    public class ConvertSpeedUnits
    {
        //// Create a program to ask the user for a distance(in meters) and the time taken
        //// (as three numbers: hours, minutes, seconds), and print the speed, in meters per second, 
        //// kilometers per hour and miles per hour.

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