namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        //// Write a program that receives some info from the console about people and their phone 
        //// numbers. Each entry should have just one name and one number (both of them strings). 

        //// On each line you will receive some of the following commands:

        ////   # A {name} {phone} – adds entry to the phonebook. In case of trying to 
        ////     add a name that is already in the phonebook you should change the 
        ////     existing phone number with the new one provided.

        ////   # S { name} – searches for a contact by given name and prints it in format 
        ////     "{name} -> {number}". In case the contact isn't found, print 
        ////     "Contact {name} does not exist.".

        ////   # END – stop receiving more commands.

        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            var input = Console.ReadLine().Split(' ').ToList();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    //// Add the name and phone number.
                    if (!phonebook.ContainsKey(input[1]))
                    {
                        phonebook.Add(input[1], input[2]);
                    }
                    else
                    {
                        phonebook[input[1]] = input[2];
                    }
                }

                if (input[0] == "S")
                {
                    //// Prints the name and phone number or If there is no such name...
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }

                //// Keep reading all commands on the console including the last row.
                 input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}