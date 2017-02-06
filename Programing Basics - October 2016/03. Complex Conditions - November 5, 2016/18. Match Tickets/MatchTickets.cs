namespace Match_Tickets
{
    using System;

    public class MatchTickets
    {
        //// Трета задача от междинния изпит на 17 юли 2016.

        //// Когато пуснали билетите за Евро 2016, група запалянковци решили да си закупят. Билетите имат 
        //// две категории с различни цени:
        ////   # VIP – 499.99 лева.      
        ////   # Normal – 249.99 лева.

        //// Запалянковците имат определен бюджет, a броят на хората в групата определя какъв процент от 
        //// бюджета трябва да се задели за транспорт:
        ////   # От 1 до 4 – 75% от бюджета.
        ////   # От 5 до 9 – 60% от бюджета.
        ////   # От 10 до 24 – 50% от бюджета.
        ////   # От 25 до 49 – 40% от бюджета.
        ////   # 50 или повече – 25% от бюджета.

        //// Напишете програма, която да пресмята дали с останалите пари от бюджета могат да си купят билети 
        //// за избраната категория. И колко пари ще им останат или ще са им нужни.

        //// Входът се чете от конзолата и съдържа точно 3 реда:
        ////   # На първия ред е бюджетът – реално число в интервала[1 000.00... 1 000 000.00]
        ////   # На втория ред е категорията – „VIP” или „Normal”
        ////   # На третия ред е броят на хората в групата – цяло число в интервала[1... 200]

        //// Да се отпечата на конзолата един ред:
        ////   # Ако бюджетът е достатъчен: “Yes! You have {N} leva left.”– N са останалите пари на групата
        ////   # Ако бюджетът НЕ Е достатъчен: “Not enough money! You need {М} leva.“ – където М е сумата, 
        ////     която не достига. 

        //// Сумите трябва да са форматирани с точност до два знака след десетичната запетая.

        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var ticketType = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            var transport = 0.0;
            var ticketPrice = 0.0;

            if (people >= 1 && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people > 4 && people <= 9)
            {
                transport = budget * 0.6;
            }
            else if (people > 9 && people <= 24)
            {
                transport = budget * 0.5;
            }
            else if (people > 24 && people <= 49)
            {
                transport = budget * 0.4;
            }
            else if (people > 49)
            {
                transport = budget * 0.25;
            }

            if (ticketType == "VIP")
            {
                ticketPrice = 499.99 * people;
            }
            else if (ticketType == "Normal")
            {
                ticketPrice = 249.99 * people;
            }

            var moneyNeed = transport + ticketPrice;

            if (moneyNeed <= budget)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - moneyNeed);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(budget - moneyNeed));
            }
        }
    }
}