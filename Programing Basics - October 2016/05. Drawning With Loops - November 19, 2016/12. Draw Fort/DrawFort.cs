namespace Draw_Fort
{
    using System;

    public class DrawFort
    {
        //// Пета задача от изпитa на 6 март 2016. 

        //// Да се напише програма, която прочита от конзолата цяло число "n" и чертае крепост с ширина 
        //// 2 * n колони и височина n реда като в примерите по-долу. Лявата и дясната колона във 
        //// вътрешността си са широки n / 2.

        //// Example: Input: 5 -> Output:  /^^\__/^^\
        ////                               |        |
        ////                               |        |
        ////                               |   __   |
        ////                               \__/  \__/

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var wide = n * 2;
            var hight = n;

            if (!(n <= 4))
            {
                Console.WriteLine("/" + new string('^', n / 2) + "\\" + new string('_', n / 2)
                    + "/" + new string('^', n / 2) + "\\");

                for (int i = 0; i < n - 3; i++)
                {
                    Console.WriteLine("|" + new string(' ', (n * 2) - 2) + "|");
                }

                Console.WriteLine("|" + new string(' ', (n / 2) + 1) + new string('_', n / 2)
                        + new string(' ', (n / 2) + 1) + "|");

                Console.WriteLine("\\" + new string('_', n / 2) + "/" + new string(' ', n / 2)
                    + "\\" + new string('_', n / 2) + "/");
            }
            else
            {
                Console.WriteLine("/" + new string('^', n / 2) + "\\" + "/" + new string('^', n / 2) + "\\");

                for (int i = 1; i < n - 2; i++)
                {
                    Console.WriteLine("|" + new string(' ', (n * 2) - 2) + "|");
                }

                Console.WriteLine("|" + new string(' ', (n * 2) - 2) + "|");

                Console.WriteLine("\\" + new string('_', n / 2) + "/" + "\\" + new string('_', n / 2) + "/");
            }
        }
    }
}