namespace Problem_02___Styrofoam
{
    using System;

    public class Styrofoam
    {
        public static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var numberOfWindows = int.Parse(Console.ReadLine());
            var styrofoamPerPackage = double.Parse(Console.ReadLine());
            var pricePerStyrofoamPacket = double.Parse(Console.ReadLine());

            var areaWithoutWindows = houseArea - (numberOfWindows * 2.4);
            var areaPlusWastage = areaWithoutWindows + (areaWithoutWindows / 10);
            var packagesStyrofoamNeeded = Math.Ceiling(areaPlusWastage / styrofoamPerPackage);
            var total = packagesStyrofoamNeeded * pricePerStyrofoamPacket;

            if (total < budget)
            {
                Console.WriteLine("Spent: {0:F2}", total);
                Console.WriteLine("Left: {0:F2}", budget - total);
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}", total - budget);
            }
        }
    }
}