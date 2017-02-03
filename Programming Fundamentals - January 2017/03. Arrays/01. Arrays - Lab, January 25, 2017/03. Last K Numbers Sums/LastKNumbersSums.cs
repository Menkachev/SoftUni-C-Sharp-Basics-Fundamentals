namespace _03.Last_K_Numbers_Sums
{
    using System;

    public class LastKNumbersSums
    {
        //// Enter two integers "n" and "k".Generate and print the following sequence of "n" elements:
        ////  The first element is: 1
        ////  All other elements = sum of the previous k elements(if less than k are available, sum all of them)

        //// Example: Input: n = 9, k = 5 -> Output: 1 1 2 4 8 16 31 61 120 (120 = 4 + 8 + 16 + 31 + 61)

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    sum = sum + numbers[j];
                }

                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
