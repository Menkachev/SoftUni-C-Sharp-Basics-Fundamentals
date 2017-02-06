namespace _3_Equal_Numbers
{
    using System;

    public class ThreeEqualNumbers
    {
        //// Три еднакви числа: да се въведат 3 числа и да се отпечата дали са еднакви(yes / no).

        public static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            
            if (number1 == number2 && number2 == number3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}