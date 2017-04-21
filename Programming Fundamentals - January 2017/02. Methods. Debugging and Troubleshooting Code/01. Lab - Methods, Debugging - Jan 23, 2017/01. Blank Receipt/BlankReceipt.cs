namespace _01.Blank_Receipt
{
    using System;
    public class BlankReceipt
    {
        // Create a method that prints a blank cash receipt.
        // The method should invoke three other methods: 
        // one for printing the header, one for the body and one for the footer of the receipt.

        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        public static void PrintReceipt()
        {
            PrintReceiptHeader();
            Body();
            Footer();
        }

        public static void Main()
        {
            PrintReceipt();
        }
    }
}