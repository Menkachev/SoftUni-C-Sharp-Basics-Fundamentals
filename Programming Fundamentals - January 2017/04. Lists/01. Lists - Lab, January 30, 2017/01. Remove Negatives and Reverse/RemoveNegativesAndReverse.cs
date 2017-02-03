namespace _01.Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        //// Read a list of integers, remove all negative numbers from it 
        //// and print the remaining elements in reversed order. In case of 
        //// no elements left in the list, print “empty”.

        public static void Main()
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           
            //// remove all negatives with loop.
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] < 0)
                {
                    number.RemoveAt(i);
                    i--;
                } 
            }

            //// remove all negatives with "RemoveAll".
            //// number.RemoveAll(x => x < 0);

            if (number.Count != 0)
            {
                number.Reverse();
                Console.WriteLine(string.Join(" ", number));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
