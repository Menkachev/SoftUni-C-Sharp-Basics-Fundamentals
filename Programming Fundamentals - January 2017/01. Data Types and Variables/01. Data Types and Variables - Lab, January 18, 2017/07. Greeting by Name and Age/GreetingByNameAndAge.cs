namespace _07.Greeting_by_Name_and_Age
{
    using System;

    public class GreetingByNameAndAge
    {
        //// Write a program that enters first name, last name and age and prints 
        //// "Hello, <first name> <last name>. You are <age> years old.".

        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}