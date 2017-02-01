namespace _01.Practice_Integers
{
    using System;

    public class PracticeIntegers
    {
        //// Create a program that assigns integer values to variables.Be sure that each value 
        //// is stored in the correct variable type(try to find the most suitable variable type 
        //// in order to save memory). Finally, you need to print all variables to the console.

        public static void Main()
        {
            sbyte num1 = -100; //// Signed
            byte num2 = 128; //// Unsigned
            short num3 = -3540; //// Signed
            ushort num4 = 64876; //// Unsigned
            uint num5 = 2147483648; //// Unsigned
            int num6 = -1141583228; //// Signed
            long num7 = -1223372036854775808; //// Signed

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }
    }
}