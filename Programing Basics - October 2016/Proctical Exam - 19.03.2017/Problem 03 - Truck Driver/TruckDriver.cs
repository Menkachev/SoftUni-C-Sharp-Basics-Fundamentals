namespace Problem_03___Truck_Driver
{
    using System;

    public class TruckDriver
    {
        public static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());

            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    kmPerMonth *= 0.75;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    kmPerMonth *= 0.95;
                }
                else if (10000 < kmPerMonth && kmPerMonth <= 20000)
                {
                    kmPerMonth *= 1.45;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    kmPerMonth *= 0.90;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    kmPerMonth *= 1.10;
                }
                else if (10000 < kmPerMonth && kmPerMonth <= 20000)
                {
                    kmPerMonth *= 1.45;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    kmPerMonth *= 1.05;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    kmPerMonth *= 1.25;
                }
                else if (10000 < kmPerMonth && kmPerMonth <= 20000)
                {
                    kmPerMonth *= 1.45;
                }
            }

            var sallary = kmPerMonth * 4;
            var totalSallary = sallary - (sallary / 10);

            Console.WriteLine("{0:F2}", totalSallary);
        }
    }
}