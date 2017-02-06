namespace Metric_Converter
{
    using System;

    public class MetricConverter
    {
        //// Да се напише програма, която преобразува разстояние между следните 8 мерни единици: 
        //// m, mm, cm, mi, in, km, ft, yd.

        public static void Main()
        {
            var millimetersToMeters = 1000;
            var centimeterstoMeters = 100;
            var milesToMeters = 0.000621371192;
            var inchesToMeters = 39.3700787;
            var kilometersToMeters = 0.001;
            var feetToMeters = 3.2808399;
            var yardsToMeters = 1.0936133;

            var distance = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            
            if (output == "mm")
            {
                distance *= millimetersToMeters;
            }
            else if (output == "cm")
            {
                distance *= centimeterstoMeters;
            }
            else if (output == "mi")
            {
                distance *= milesToMeters;
            }
            else if (output == "in")
            {
                distance *= inchesToMeters;
            }
            else if (output == "km")
            {
                distance *= kilometersToMeters;
            }
            else if (output == "ft")
            {
                distance *= feetToMeters;
            }
            else if (output == "yd")
            {
                distance *= yardsToMeters;
            }

            if (input == "mm")
            {
                distance /= millimetersToMeters;
            }
            else if (input == "cm")
            {
                distance /= centimeterstoMeters;
            }
            else if (input == "mi")
            {
                distance /= milesToMeters;
            }
            else if (input == "in")
            {
                distance /= inchesToMeters;
            }
            else if (input == "km")
            {
                distance /= kilometersToMeters;
            }
            else if (input == "ft")
            {
                distance /= feetToMeters;
            }
            else if (input == "yd")
            {
                distance /= yardsToMeters;
            }

            Console.WriteLine(distance);
        }
    }
}