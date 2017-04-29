namespace Exercise_1
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distancePerThousandFlaps = decimal.Parse(Console.ReadLine());
            var ednurance = int.Parse(Console.ReadLine());

            var metersTraveled = (wingFlaps / 1000) * distancePerThousandFlaps;

            var flaps = (wingFlaps / 100);
            var fiveSecondsRest = (wingFlaps / ednurance) * 5;
            var secondsPassed = flaps + fiveSecondsRest;

            Console.WriteLine("{0:F2} m.", metersTraveled);
            Console.WriteLine("{0} s.", secondsPassed);
        }
    }
}