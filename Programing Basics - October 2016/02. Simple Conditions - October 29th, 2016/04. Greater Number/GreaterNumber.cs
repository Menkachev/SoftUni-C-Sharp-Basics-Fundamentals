namespace Greater_Number
{
    using System;

    public class GreaterNumber
    {
        //// Да се напише програма, която въвежда две цели числа и отпечатва по-голямото от двете.

        public static void Main()
        {
            Console.WriteLine("Enter two integers");

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("greater number: " + num1);
            }
            else
            {
                Console.WriteLine("greater number: " + num2);
            }
        }
    }
}
