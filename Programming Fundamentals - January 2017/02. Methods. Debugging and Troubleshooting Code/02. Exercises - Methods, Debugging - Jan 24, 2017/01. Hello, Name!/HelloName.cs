namespace _01.Hello__Name_
{
    using System;

    public class HelloName
    {
        // Write a method that receives a name as parameter and prints on the console “Hello, <name>!”

        public static void Main()
        {
            GreetingsByName(Console.ReadLine());
        }

        public static void GreetingsByName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}