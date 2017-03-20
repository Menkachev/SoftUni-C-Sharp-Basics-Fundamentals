namespace Basics_Exam___19._03._2017
{
    using System;

    public class GrapeAndRakia
    {
        public static void Main(string[] args)
        {
            var areaOfVineyard = double.Parse(Console.ReadLine());
            var kgPerSqrtMeter = double.Parse(Console.ReadLine());
            var loss = double.Parse(Console.ReadLine());

            var allKg = areaOfVineyard * kgPerSqrtMeter;
            var goodKg = allKg - loss;

            var kgForRakia = (goodKg * 45) / 100;
            var rakia = kgForRakia / 7.5;
            var profitFromRakia = rakia * 9.8;

            var grapeForSell = (goodKg * 55) / 100;
            var profitFromGrape = grapeForSell * 1.5;

            Console.WriteLine("{0:F2}", profitFromRakia);
            Console.WriteLine("{0:F2}", profitFromGrape);
        }
    }
}