namespace Exam_Preparation_II
{
    using System;

    public class CharityMarathon 
    {
        public static void Main()
        {
            var marathonDays = decimal.Parse(Console.ReadLine());
            var numberOfRunners = decimal.Parse(Console.ReadLine());
            var numberOfLaps = decimal.Parse(Console.ReadLine());
            var trackLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var donatedMoneyPerKilometer = decimal.Parse(Console.ReadLine());

            var maxRunners = trackCapacity * marathonDays;

            if (numberOfRunners > maxRunners)
            {
                numberOfRunners = maxRunners;
            }

            var totalMeters = numberOfRunners * numberOfLaps * trackLength;
            var totalKilometers = totalMeters / 1000;

            var raisedMoney = totalKilometers * donatedMoneyPerKilometer;

            Console.WriteLine($"Money raised: {raisedMoney:F2}"); 
        }
    }
}