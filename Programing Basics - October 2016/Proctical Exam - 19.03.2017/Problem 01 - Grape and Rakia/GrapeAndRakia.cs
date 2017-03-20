namespace Basics_Exam___19._03._2017
{
    using System;

    public class GrapeAndRakia
    {
        // Задача 1. Грозде и ракия

        // Напишете програма която да пресмята колко пари ще изкара фермер от продажбата на грозде 
        // и ракия. За целта ще получите колко квадратни метра е лозето, колко килограма грозде се 
        // изкарва от квадратен метър и колко килограма брак има. От останалото грозде 45 % се 
        // заделят за ракия и 55% са продажба. За 1 литър ракия са нужни 7.5 килограма грозде. 
        // Литър ракия струва 9.80 лева, а килограм грозде – 1.50 лева. Като резултат изпринтирайте 
        // прихода от ракия и прихода от грозде.

        // Вход
        // От конзолата се четат 3 реда:
        // 1.	Площта на лозето – реално чилсо в интервала [1.00...10000.00]
        // 2.	Килограми изкарани от квадратен метър – реално чилсо в интервала [1.00...100.00]
        // 3.	Брак – реално чилсо в интервала [2.00...1000.00]

        // Изход
        // Да се отпечатат на конзолата две числа всяко на нов ред:
        // •	Прихода от ракия
        // •	Прихода от грозде
        // Форматирани до вторият знак след десетичната запетая.

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