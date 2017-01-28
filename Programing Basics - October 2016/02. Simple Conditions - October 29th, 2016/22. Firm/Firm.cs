namespace Firm
{
    using System;

    public class Firm
    {
                             //// Втора задача от междинния изпит на 28 август 2016. 
        //// Фирма получава заявка за изработването на проект, за който са необходими определен брой часове.
        //// Фирмата разполага с определен брой дни.През 10% от дните служителите са на обучение и не могат да
        //// работят по проекта.Един нормален работен ден във фирмата е 8 часа.Всеки служител може да работи по
        //// проекта в извънработно време по 2 часа на ден.
        //// Часовете трябва да са закръглени към по-ниско цяло число(Например –> 6.98 часа се закръглят на 6 часа).
        //// Напишете програма, която изчислява дали фирмата може да завърши проекта навреме и колко часа не достигат 
        //// или остават.

        public static void Main()
        {
            var hoursNeed = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var realWorkTime = Math.Floor((days - (days * 0.1)) * 8);
            var overtime = workers * (2 * days);
            var allTime = realWorkTime + overtime;

            if (allTime >= hoursNeed)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Abs(hoursNeed - allTime));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(allTime - hoursNeed));
            }
        }
    }
}