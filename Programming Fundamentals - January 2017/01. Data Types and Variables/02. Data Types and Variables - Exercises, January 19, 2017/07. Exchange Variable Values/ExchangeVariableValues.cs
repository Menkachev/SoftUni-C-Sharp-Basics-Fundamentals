namespace _07.Exchange_Variable_Values
{
    using System;

    public class ExchangeVariableValues
    {
        //// Declare two integer variables a and b and assign them with 5 and 10 
        //// and after that exchange their values by using some programming logic.
        //// Print the variable values before and after the exchange.

        public static void Main()
        {
            //// Before the exchange.
            int a = 5;
            int b = 10;

            int temp;

            Console.WriteLine("Before: \r\na = {0} \r\nb = {1}", a, b);

            //// After...
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After: \r\na = {0}\r\nb = {1}", a, b); 
        }
    }
}