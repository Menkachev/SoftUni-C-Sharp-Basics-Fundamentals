namespace Password_Guess
{
    using System;

    public class PasswordGuess
    {
        //// Да се напише програма, която въвежда парола(един ред с произволен текст) и проверява дали въведеното
        //// съвпада с фразата “s3cr3t!P @ssw0rd”. При съвпадение да се изведе “Welcome”. При несъвпадение да се
        //// изведе “Wrong password!”. 

        public static void Main()
        {
            var enterPassword = Console.ReadLine();

            if (enterPassword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome", enterPassword);
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}