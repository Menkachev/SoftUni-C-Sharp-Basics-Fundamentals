namespace _02.Reverse_Array_of_Integers
{
    using System;

    public class ReversArrayOfIntegers
    {
        //// Write a program to read an array of integers, reverse it and print its elements.
        //// The input consists of a number "n" (the number of elements) + n integers,
        //// each as a separate line. Print the output on a single line (space separated).

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var arrayOfNumbers = new int[number];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arrayOfNumbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }

            //// Second Solution

            // var reversedNumbers = new int[arrayOfNumbers.Length];

            // for (int i = 0; i < arrayOfNumbers.Length; i++)
            // {
            //    reversedNumbers[i] = arrayOfNumbers[arrayOfNumbers.Length - i - 1]; 
            // }
        }
    }
}
