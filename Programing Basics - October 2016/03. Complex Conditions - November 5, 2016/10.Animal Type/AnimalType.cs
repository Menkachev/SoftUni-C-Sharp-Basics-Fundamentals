namespace _10.Animal_Type
{
    using System;

    public class AnimalType
    {
        //// Write a program to print animal type by its name:
        ////   # dog -> mammal
        ////   # crocodile, tortoise, snake -> reptile
        ////   # others -> unknown

        //// Example: Input: snake -> Output: reptile;    Input: cat -> Output: unknown

        public static void Main()
        {
            var animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}