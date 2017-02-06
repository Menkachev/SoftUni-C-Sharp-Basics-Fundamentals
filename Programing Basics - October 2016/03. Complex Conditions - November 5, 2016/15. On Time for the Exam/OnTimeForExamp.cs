namespace _03.On_Time_for_the_Exam
{
    using System;

    public class OnTimeForExamp
    {
        //// Трета задача от междинния изпит на 6 март 2016. 

        //// Студент трябва да отиде на изпит в определен час(например в 9:30 часа). Той идва в изпитната 
        //// зала в даден час на пристигане(например 9:40). Счита се, че студентът е дошъл навреме, ако е 
        //// пристигнал в часа на изпита или до половин час преди това. Ако е пристигнал по-рано повече от 
        //// 30 минути, той е подранил. Ако е дошъл след часа на изпита, той е закъснял. Напишете програма, 
        //// която въвежда време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме, 
        //// дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.

        //// От конзолата се четат 4 цели числа (по едно на ред):
        ////    # Първият ред съдържа час на изпита – цяло число от 0 до 23.
        ////    # Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
        ////    # Третият ред съдържа час на пристигане – цяло число от 0 до 23.
        ////    # Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.

        //// На първият ред от изхода отпечатайте:
        ////    # “Late”, ако студентът пристига по-късно от часа на изпита.
        ////    # “On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
        ////    # “Early”, ако студентът пристига повече от 30 минути преди часа на изпита.

        //// Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
        ////    # “mm minutes before the start” за идване по-рано с по-малко от час.
        ////    # “hh:mm hours before the start” за подраняване с 1 час или повече. Минутите винаги печатайте 
        ////      с 2 цифри, например “1:05”.
        ////    # “mm minutes after the start” за закъснение под час.
        ////    # “hh:mm hours after the start” за закъснение от 1 час или повече. Минутите винаги печатайте 
        ////      с 2 цифри, например “1:03”.

        //// Пример: Input: 9, 30, 9, 50 -> Output: Late, 20 minutes after the start

        public static void Main()
        {
            var hourOfExamp = int.Parse(Console.ReadLine());
            var minOfExamp = int.Parse(Console.ReadLine());
            var hourOfArrive = int.Parse(Console.ReadLine());
            var minOfArrive = int.Parse(Console.ReadLine());

            var timeExamp = (hourOfExamp * 60) + minOfExamp;
            var timeArrive = (hourOfArrive * 60) + minOfArrive;
            var timeDiff = timeArrive - timeExamp;

            if (timeDiff < -30)
            {
                Console.WriteLine("Early");
            }
            else if (timeDiff <= 0)
            {
                Console.WriteLine("On Time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (timeDiff != 0)
            {
                var hours = Math.Abs(timeDiff / 60);
                var min = Math.Abs(timeDiff % 60);

                if (hours > 0)
                {
                    if (min < 10)
                    {
                        Console.WriteLine(hours + ":0" + min + " hours");
                    }
                    else
                    {
                        Console.WriteLine(hours + ":" + min + "hours");
                    }
                }
                else
                {
                    Console.WriteLine(min + "minutes");
                }

                if (timeDiff < 0)
                {
                    Console.WriteLine(" before the start");
                }
                else
                {
                    Console.WriteLine(" after the start");
                }
            }
        }
    }
}