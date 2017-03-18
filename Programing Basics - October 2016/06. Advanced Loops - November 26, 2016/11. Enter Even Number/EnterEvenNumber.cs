namespace _11.Enter_Even_Number
{
    using System;

    public class EnterEvenNumber
    {
        // Напишете програма, която въвежда четно число. Ако потребителят въведе грешно число 
        // (нечетно число или стринг, който не е цяло число), трябва да му излиза съобщение 
        // за грешка и да въвежда отново. 

        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter even number:");

                    var n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number."); 
                }
            }
        }
    }
}