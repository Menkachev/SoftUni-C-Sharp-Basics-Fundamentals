namespace _04.Variable_in_Hex_Format
{
    using System;

    public class VariableInHexFormat
    {
        //// Write a program that reads a number in hexadecimal format(0x##). 
        //// Convert it to decimal format and prints it.

        public static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}