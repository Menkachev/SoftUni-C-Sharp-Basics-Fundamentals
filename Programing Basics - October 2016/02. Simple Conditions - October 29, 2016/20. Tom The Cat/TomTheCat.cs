namespace Tom_The_Cat
{
    using System;

    public class TomTheCat
    {
                          //// Втора задача от междинния изпит на 24 април 2016. 
        //// Напишете програма, която пресмята колко вино може да се произведе и дали това количество е
        //// достатъчно. Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.

        public static void Main()
        {
            var holidays = int.Parse(Console.ReadLine());

            var workingdays = (365 - holidays) * 63;
            var notWorkingDays = holidays * 127;
            var allPlayTime = workingdays + notWorkingDays;

            var difference = allPlayTime - 30000;
            var hours = Math.Abs(difference / 60);
            var minutes = Math.Abs(difference % 60);

            if (allPlayTime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}