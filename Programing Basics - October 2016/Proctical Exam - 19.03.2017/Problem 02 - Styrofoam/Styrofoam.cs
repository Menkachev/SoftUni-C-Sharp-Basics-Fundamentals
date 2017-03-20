namespace Problem_02___Styrofoam
{
    using System;

    public class Styrofoam
    {
        // Задача 2. Стиропор

        // Напишете програма която да пресмята колко пари ще останат или няма да достигнат за 
        // поръчката на стиропор за къща. Програма ще получава на входа: бюджета с който 
        // разполагате, площта на къщата, броят прозорци, колко кв.метри има в един пакет 
        // стиропор и цената на един пакет.

        // От площта на къщата трябва да се извади площта на всички прозорци, като всеки прозорец 
        // има площ 2.4м2. Към полученото количество трябва да се прибавят 10% за фира. След което 
        // се пресметне колко пакета са нужни. Пакетите се загръглят нагоре. Пример: При площ 205м2 
        // и пакет от 20м2 са нужни 10.25 пакета -> 11 пакета. След като се пресметне цената на 
        // всичкия стиропор трябва да се изкара съобщение дали бюджета стига или не.

        // Вход
        // От конзолата се четат 5 реда:
        // •	Първи ред – бюджет – реално число в интервала [1.00...10000.00]
        // •	Втори ред – площ на къщата – реално число в интервала [1.00...10000.00]
        // •	Трети ред – броят прозорци – цяло число в интервала [1...100]
        // •	Четвърти ред – колко кв.метри стиропор има в един пакет – реално число в интервала [1.00...100.00]
        // •	Пети ред – цената на един пакет стиропор – реално число в интервала [1.00...100.00]

        // Изход
        // На конзолата се отпечатва:
        // •	Ако бюджета е достатъчен се отпечатват два реда:
        // o   "Spent: {цената на стиропора}"
        // o   "Left: {оставащите пари}"
        // •	Ако бюджета НЕ е достатъчен се отпечатват един ред:
        // o   "Need more: {недостигащите пари}"
        // Форматирани до вторият знак след десетичната запетая.
        
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