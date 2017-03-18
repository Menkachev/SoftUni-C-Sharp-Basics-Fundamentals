namespace _13.Number_Pyramid
{
    using System;

    public class NumberPyramid
    {
        // Напишете програма, която въвежда цяло число n и отпечатва пирамида от числа.
        
        // Example: Input: 10  ->  Output: 1
        //                                 2 3
        //                                 4 5 6
        //                                 7 8 9 10

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                        counter++;
                        Console.Write(counter + " ");

                    if (counter == n)
                    {
                        return;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}