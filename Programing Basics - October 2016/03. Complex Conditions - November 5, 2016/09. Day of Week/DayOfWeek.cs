namespace _9.Day_of_Week
{
    using System;

    public class DayOfWeek
    {
        //// Print the day name(in English) by day number in range[1...7] 
        //// or print “Error” for invalid day number.

        //// Example: Input: 5 -> Output: Friday;    Input: -1 -> Output: Error

        public static void Main()
        {
            var day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}