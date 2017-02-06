namespace Fruit_or_Vegetable
{
    using System;

    public class FruitOrVegetable
    {
        //// Да се напише програма, която въвежда име на продукт и проверява дали е плод или зеленчук.

        ////    # Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes.
        ////    # Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot.
        ////    # Всички останали са "unknown".

        //// Да се изведе “fruit”, “vegetable” или “unknown” според въведения продукт.

        //// Пример: Input: tomato -> Output: vegetable

        public static void Main()
        {
            var f = Console.ReadLine();

            if (f == "banana" || f == "apple" || f == "kiwi" || f == "cherry" || f == "lemon" || f == "grapes")
            {
                Console.WriteLine("Fruit");
            }
            else if (f == "tomato" || f == "cucumber" || f == "pepper" || f == "carrot")
            {
                Console.WriteLine("Vegetable");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }
}