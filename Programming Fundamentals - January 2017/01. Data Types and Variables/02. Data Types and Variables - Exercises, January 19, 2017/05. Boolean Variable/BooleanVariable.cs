namespace _05.Boolean_Variable
{
    using System;

    public class BooleanVariable
    {
        //// Write a program that reads a string, converts it to Boolean variable 
        //// and prints “Yes” if the variable is true and “No” if the variable is false.

        public static void Main()
        {
            string input = Console.ReadLine();
            bool boolean = Convert.ToBoolean(input);

            if (boolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}