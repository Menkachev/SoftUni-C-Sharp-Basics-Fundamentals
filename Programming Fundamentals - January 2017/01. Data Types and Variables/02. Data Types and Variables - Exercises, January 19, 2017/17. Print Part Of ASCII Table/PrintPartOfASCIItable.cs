namespace _17.Print_Part_Of_ASCII_Table
{
    using System;

    public class PrintPartOfASCIITable
    {
        //// Find online more information about ASCII(American Standard Code for Information Interchange) 
        //// and write a program that prints part of the ASCII table of characters at the console.
        //// On the first line of input you will receive the char index you should start with and 
        //// on the second line - the index of the last character you should print.

        //// Example: Input: 60, 65 -> Output: < = > ? @ A

        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            char charStartNumber = Convert.ToChar(startNumber);
            char charEndNumber = Convert.ToChar(endNumber);

            for (int i = charStartNumber; i <= charEndNumber; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
