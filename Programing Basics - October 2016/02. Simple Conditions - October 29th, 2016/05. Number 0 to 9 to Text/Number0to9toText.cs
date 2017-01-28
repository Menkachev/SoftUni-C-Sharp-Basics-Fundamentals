namespace Number_0._._._9_to_Text
{
    using System;

    public class Number0to9toText
    {
        //// Да се напише програма, която въвежда цяло число в диапазона[0…10] и го изписва с думи на английски език.
        //// Ако числото е извън диапазона, изписва “number too big”. 

        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            //// switch-case construction.

            switch (num)
            {
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                case 6: Console.WriteLine("six");
                    break;
                case 7: Console.WriteLine("seven");
                    break;
                case 8: Console.WriteLine("eight");
                    break;
                case 9: Console.WriteLine("nine");
                    break;

                default: Console.WriteLine("number too big");
                    break;       
            }

            //// if-else construction.

            if (num == 1)
            {
                Console.WriteLine("one");
            }
            else if (num == 2)
            {
                Console.WriteLine("two");
            }
            else if (num == 3)
            {
                Console.WriteLine("three");
            }
            else if (num == 4)
            {
                Console.WriteLine("four");
            }
            else if (num == 5)
            {
                Console.WriteLine("five");
            }
            else if (num == 6)
            {
                Console.WriteLine("six");
            }
            else if (num == 7)
            {
                Console.WriteLine("seven");
            }
            else if (num == 8)
            {
                Console.WriteLine("eight");
            }
            else if (num == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            } 
        }
    }
}
