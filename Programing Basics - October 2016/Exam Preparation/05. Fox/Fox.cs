namespace _05.Fox
{
    using System;

    public class Fox
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', ((n - n) + 1) + i));
                Console.Write("\\");
                Console.Write(new string('-', (((2 * n) - 1) - i) - i));
                Console.Write("/");
                Console.WriteLine(new string('*', ((n - n) + 1) + i)); 
            }

            //second part
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine(
                    "|" + 
                    new string('*', (n / 2) + i) + 
                    "\\" + 
                    new string('*', (n - i) - i) + 
                    "/" + 
                    new string('*', (n / 2) + i) + 
                    "|");
            }

            //third part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', ((n - n) + 1) + i));
                Console.Write("\\");
                Console.Write(new string('*', (((2 * n) - 1) - i) - i));
                Console.Write("/");
                Console.WriteLine(new string('-', ((n - n) + 1) + i));
            }
        }
    }
}