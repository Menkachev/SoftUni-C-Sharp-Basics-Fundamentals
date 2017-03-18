namespace _01.Numbers_1._._.N_with_Step_3
{
    using System;

    public class NumbersFrom1ToNWithStep3
    {
        // Напишете програма, която въвежда число n и отпечатва числата от 1 до n през 3 
        // (със стъпка 3). 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}