namespace Stop
{
    using System;

    public class Stop
    {
        //// Пета задача от изпитa на 26 март 2016. 

        //// Да се напише програма, която прочита от конзолата цяло число "N" и чертае предупредителен знак 
        //// "STOP" като в примерa по-долу.

        //// Example: Input: 3 -> Output:  ...._______....
        ////                               ...//_____\\...
        ////                               ..//_______\\..
        ////                               .//_________\\.
        ////                               //___STOP!___\\
        ////                               \\___________//
        ////                               .\\_________//.
        ////                               ..\\_______//..

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', (n * 2) + 1));
            Console.WriteLine(new string('.', n + 1));

            ////Upper part.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n - i) + "//" + (new string('_', ((n * 2) - 1) + i + i)
                    + "\\\\" + new string('.', n - i)));
            }

            //// Middle part.
            Console.WriteLine("//" + new string('_', (n * 2) - 3) + "STOP!" + new string('_', (n * 2) - 3) + "\\\\");
            Console.WriteLine("\\\\" + new string('_', (n * 4) - 1) + "//");

            //// Bottom part.
                for (int i = n - 1; i > 0; i--)
            {
                Console.WriteLine(new string('.', n - i) + "\\\\" + (new string('_', ((n * 2) - 1) + i + i)
                    + "//" + new string('.', n - i)));
            }
        }
    }
}