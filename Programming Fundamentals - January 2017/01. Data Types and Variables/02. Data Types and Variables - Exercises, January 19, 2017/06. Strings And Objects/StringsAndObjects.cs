namespace _06.Strings_And_Objects
{
    using System;

    public class StringsAndObjects
    {
        //// Declare two string variables and assign them with “Hello” and “World”. Declare an 
        //// object variable and assign it with the concatenation of the first two variables
        //// (mind adding an interval between). Declare a third string variable and initialize 
        //// it with the value of the object variable(you should perform type casting).

        public static void Main()
        {
            string greeting = "Hello";
            string world = "World";

            Console.WriteLine($"{greeting} {world}");
        }
    }
}