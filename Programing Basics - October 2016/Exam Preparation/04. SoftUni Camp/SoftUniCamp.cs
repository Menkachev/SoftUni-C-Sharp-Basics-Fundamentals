namespace _04.SoftUni_Camp
{
    using System;

    public class SoftUniCamp
    {
        public static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());

            var cars = 0.0;
            var microbus = 0.0;
            var litleBus = 0.0;
            var bigBus = 0.0;
            var train = 0.0;

            var allPeople = 0.0;

            for (int i = 0; i < groups; i++)
            {
                var num = int.Parse(Console.ReadLine());
                allPeople = allPeople + num;

                if (num <= 5)
                {
                    cars = cars + num;
                }
                else if (num > 5 && num <= 12)
                {
                    microbus += num;
                }
                else if (num > 12 && num <= 25)
                {
                    litleBus += num;
                }
                else if (num > 25 && num <= 40)
                {
                    bigBus += num;
                }
                else if (num > 40)
                {
                    train += num;
                }
            }

            Console.WriteLine("{0:f2}%", (cars / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (microbus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (litleBus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (bigBus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (train / allPeople) * 100);
        }
    }
}