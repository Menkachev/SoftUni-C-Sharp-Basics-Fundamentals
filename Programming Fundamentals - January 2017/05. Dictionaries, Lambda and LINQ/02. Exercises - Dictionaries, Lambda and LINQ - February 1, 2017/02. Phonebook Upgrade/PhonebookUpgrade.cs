namespace _02.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        //// Add functionality to the phonebook from the previous task to print all contacts 
        //// ordered lexicographically when receive the command “ListAll”.

        public static void Main()
        {
            //// To sort the contacts use "Sortet Dictionary".
            var phonebook = new SortedDictionary<string, string>();

            var input = Console.ReadLine().Split(' ').ToList();

            while (input[0] != "END")
            {
                //// Sort all contacts lexicographically.
                if (input[0] == "ListAll")
                {
                    foreach (var value in phonebook)
                    {
                        Console.WriteLine($"{value.Key} -> {value.Value}");
                    }
                }
                
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