namespace Invalid_Number
{
    using System;

    public class InvalidNumber
    {
        //// Дадено число е валидно, ако е в диапазона[100…200] или е 0. Да се напише програма, 
        //// която въвежда цяло число и печата “invalid” ако въведеното число не е валидно.

        //// Пример: Input: 220 -> Output: invalid;    

        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var range = 100 <= number && number <= 200 || number == 0;

            if (!range)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}