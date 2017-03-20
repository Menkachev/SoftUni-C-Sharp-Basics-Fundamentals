namespace Butterfly
{
    using System;

    public class Butterfly
    {
        //// Пета задача от изпитa на 26 март 2016. 

        //// Да се напише програма, която прочита от конзолата цяло число "n" и чертае пеперуда с ширина 
        //// 2 * n - 1 колони и височина 2 * (n - 2) + 1 реда. Лявата и дясната ѝ част са широки n - 1.

        //// Example: Input: 5 -> Output:  ***\ /***
        ////                               ---\ /---
        ////                               ***\ /***
        ////                                   @
        ////                               ***/ \***
        ////                               ---/ \---
        ////                               ***/ \***

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var wide = (2 * n) - 1;
            var hight = (2 * (n - 2)) + 1;

            // Upper part
            for (int i = 0; i < n - 2; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('*', n - 2));
                }
            }

            // Middle part
            Console.Write(new string(' ', n - 1));
            Console.Write(new string('@', 1));
            Console.WriteLine(new string(' ', n - 1));

            // Bottom part
            for (int i = 0; i < n - 2; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.WriteLine(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.WriteLine(new string('*', n - 2));
                }
            }
        }
    }
}