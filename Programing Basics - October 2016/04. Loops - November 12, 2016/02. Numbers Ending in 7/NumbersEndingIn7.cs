namespace _02.Numbers_Ending_in_7
{
    using System;

    public class NumbersEndingIn7
    {
        //// Напишете програма, която отпечатва числата в диапазона[1…1000], които завършват на 7.

        public static void Main()
        {
            for (int i = 7; i < 1000; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}