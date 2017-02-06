namespace Harvest
{
    using System;

    public class Harvest
    {
                                  //// Втора задача от междинния изпит на 17 юли 2016. 
        //// От лозе с площ X квадратни метри се заделя 40% от реколтата за производство на вино.От 1 кв.м лозе се
        //// изкарват Y килограма грозде.За 1 литър вино са нужни 2,5 кг.грозде.Желаното количество вино за продан е Z литра.

        public static void Main()
        {
            var kvmLoze = double.Parse(Console.ReadLine());
            var grapePerM = double.Parse(Console.ReadLine());
            var ltrNeeded = double.Parse(Console.ReadLine());
            var nuberOfWorkers = int.Parse(Console.ReadLine());

            var allKg = (kvmLoze * grapePerM) * 0.4;
            var allLtrs = allKg / 2.5;
            var ltrsLeft = allLtrs - ltrNeeded;

            if (ltrNeeded <= allLtrs)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(allLtrs));

                Console.WriteLine(
                    "{0} liters left -> {1} liters per person.", 
                    Math.Ceiling(ltrsLeft), 
                    Math.Ceiling(ltrsLeft / nuberOfWorkers));
            }
            else
            {
                Console.WriteLine(
                    "It will be a tough winter! More {0} liters wine needed.", 
                    Math.Floor(ltrNeeded - allLtrs));
            }
        }
    }
}