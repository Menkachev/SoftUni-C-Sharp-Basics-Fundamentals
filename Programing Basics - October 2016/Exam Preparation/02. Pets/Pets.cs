namespace _02.Pets
{
    using System;

    public class Pets
    {
        public static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodKg = int.Parse(Console.ReadLine());
            var dogFoodPerDay = double.Parse(Console.ReadLine());
            var catFoodPerDay = double.Parse(Console.ReadLine());
            var turtleFoodPerDay = double.Parse(Console.ReadLine());

            var dogFood = dogFoodPerDay * days;
            var catFood = catFoodPerDay * days;
            var turtleFood = (turtleFoodPerDay / 1000) * days;

            var neededFood = dogFood + catFood + turtleFood;

            if (neededFood <= foodKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodKg - neededFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(neededFood - foodKg));
            }
        }
    }
}