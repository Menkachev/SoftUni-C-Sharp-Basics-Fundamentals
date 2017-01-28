namespace Equal_Words
{
    using System;

    public class EqualWords
    {
        //// Да се напише програма, която въвежда две думи и проверява дали са еднакви.Да не се прави разлика
        //// между главни и малки думи.Да се изведе “yes” или “no”. 

        public static void Main()
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            
            if (firstWord.ToLower() == secondWord.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}