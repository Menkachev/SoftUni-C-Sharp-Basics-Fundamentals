namespace _05.Boolean_Variable
{
    using System;

    public class BooleanVariable
    {
        //// Write a program that reads a string, converts it to Boolean variable 
        //// and prints “Yes” if the variable is true and “No” if the variable is false.

        //// Example: Input: True -> Output: Yes,  Input: False -> Output: No

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