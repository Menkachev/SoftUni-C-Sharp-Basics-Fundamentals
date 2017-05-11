namespace Problem_1
{
    using System;
    public class SplinterTrip
    {
        // Sam the Spy just got his shiny new military aircraft, the C-147B Paladin, and a shiny new 
        // mission to carry out. The problem is, he needs to fly there using the Paladin, and you're 
        // going to help him with calculating the fuel consumption and total flight time.

        // The Paladin, being a big plane, consumes a lot of fuel - 25L per mile to be exact.
        // Also, before taking off, the commanding Fuel Consumption Officer(you) needs to calculate the 
        // miles traveled in heavy winds.Heavy winds need 1.5 times more fuel.

        // Finally, since fuel consumption is always going to vary a little, we need to have a bit more 
        // fuel just in case. So, the total fuel amount we put in needs to increase by 5%.

        // When we calculate the fuel consumption, we need to print it on the console in the following format:
        //  # “Fuel needed: {totalFuelNeeded} L”

        // After all of these calculations, we need to see if the fuel in the tank will be enough:
        // - If it’s enough, print: 
        //  # “Enough with {remainingFuel} L to spare!”
        // - If the fuel won’t be enough, print:
        //  # “We need {fuelNeeded} L more fuel.”

        // All floating-point numbers in the output are rounded to the second decimal place.
    
        // Input
        // # First line – the trip distance in miles – floating-point number in range[1.00…250000.00].
        // # Second line – the fuel tank capacity in liters – floating-point number in range[1.00…100000.00].
        // # Third line – the miles spent in heavy winds – floating-point number in range[0.00…50000.00].
       
        // Output
        // # First line – The total fuel consumption – rounded to the second decimal place
        // # Second line – whether the plane will have enough fuel

        // All the output needs to be as per the formats stated above.

        public static void Main(string[] args)
        {
            var travelDistance = decimal.Parse(Console.ReadLine());
            var fuelTankCapacity = float.Parse(Console.ReadLine());
            var milesInHeavyWinds = float.Parse(Console.ReadLine());

            var milesInNonHeavyWinds = (float)travelDistance - milesInHeavyWinds;
            var nonHeavyWindsConsumption = milesInNonHeavyWinds * 25;
            var heavyWindsConsumption = milesInHeavyWinds * (25 * 1.5);

            var fuelConsumption = nonHeavyWindsConsumption + heavyWindsConsumption;
            var tolerance = (fuelConsumption * 5) / 100;

            var totalFuelConsumption = fuelConsumption + tolerance;
            var remainingFuel = fuelTankCapacity - totalFuelConsumption;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:F2}L");

            if (fuelTankCapacity >= totalFuelConsumption)
            {
                Console.WriteLine($"Enough with {remainingFuel:F2}L to spare!");
            }
            else
            {
                var fuelNeeded = totalFuelConsumption - fuelTankCapacity;
                Console.WriteLine($"We need {fuelNeeded:F2}L more fuel.");
            }
        }
    }
}
