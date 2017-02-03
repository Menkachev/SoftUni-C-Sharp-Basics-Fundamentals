namespace _04.Elevator
{
    using System;

    public class Elevator
    {
        //// Calculate how many courses will be needed to elevate "n" persons by using an elevator 
        //// of capacity of "p" persons. The input holds two lines: the number of people "n" 
        //// and the capacity "p" of the elevator.

        //// Example: Input: 17, 3 -> Output: 6    Comments: 5 courses * 3 people + 1 course * 2 persons

        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);

            Console.WriteLine(courses);
        }
    }
}