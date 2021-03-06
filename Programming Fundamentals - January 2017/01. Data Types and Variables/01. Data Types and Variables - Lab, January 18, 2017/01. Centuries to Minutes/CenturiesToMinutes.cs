﻿namespace _01.Centuries_to_Minutes
{
    using System;

    public class CenturiesToMinutes
    {
        //// Write program to enter an integer number of centuries and convert it to 
        //// years, days, hours and minutes.

        //// Example: Input: 1 -> Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes

        public static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine(
                "{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", 
                centuries, 
                years, 
                days, 
                hours, 
                minutes);
        }
    }
}