namespace _09.Vowels_Sum
{
    using System;

    public class VowelsSum
    {
        //// Да се напише програма, която въвежда текст (стринг) и изчислява и отпечатва 
        //// сумата от стойностите на гласните букви според таблицата по-долу:

        //// буква    | a | e | i | o | u
        //// стойност | 1 | 2 | 3 | 4 | 5

        //// Пример: Input: hello -> Output: 6   Comments: e + o = 2 + 4 = 6

        public static void Main()
        {
            var text = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];

                switch (letter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
