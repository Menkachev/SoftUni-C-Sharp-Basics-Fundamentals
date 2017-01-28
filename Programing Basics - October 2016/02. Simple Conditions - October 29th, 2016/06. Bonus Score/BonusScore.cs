namespace Bonus_Score
{
    using System;

    public class BonusScore
    {
        //// Дадено е цяло число – брой точки.Върху него се начисляват бонус точки по правилата, описани по-долу.
        //// Да се напише програма, която пресмята бонус точките за това число и общия брой точки с бонусите.
        ////    Ако числото е до 100 включително, бонус точките са 5.
        ////    Ако числото е по-голямо от 100, бонус точките са 20% от числото.
        ////    Ако числото е по-голямо от 1000, бонус точките са 10% от числото.
        ////    Допълнителни бонус точки (начисляват се отделно от предходните):
                ////   За четно число -> + 1 т.
                ////   За число, което завършва на 5 -> + 2 т.

        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (num <= 100)
            {
                bonusPoints += 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bonusPoints += num * 0.2;
            }
            else if (num > 1000)
            {
                bonusPoints += num * 0.1;
            }

            if (num % 2 == 0)
            {
                bonusPoints++;
            }
            else if (num % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(num + bonusPoints);
        }
    }
}