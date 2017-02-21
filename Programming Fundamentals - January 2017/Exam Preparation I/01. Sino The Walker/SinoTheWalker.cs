namespace Exam_Preparation_I
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var timeFormat = "HH:mm:ss";
            var timeLeaving = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
            var numberOfSteps = int.Parse(Console.ReadLine());
            var timeForEachStepInSeconds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSteps; i++)
            {
               timeLeaving = timeLeaving.AddSeconds(timeForEachStepInSeconds);
            }

            var result = timeLeaving.ToString(timeFormat);

            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}