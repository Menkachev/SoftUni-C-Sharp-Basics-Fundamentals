namespace Problem_05___Parallelepiped
{
    using System;

    public class Parallelepiped
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // Top row.

            Console.WriteLine(
                "+" 
                + new string('~', n - 2) 
                + "+" 
                + new string('.', (n * 2) + 1));

            // Middle upper part.

            var leftDoths = 0;
            var rightDoths = n * 2;

            for (int i = 0; i < (n * 2) + 1; i++)
            {
                Console.WriteLine(
                    "|" 
                    + new string('.', leftDoths) 
                    + "\\" 
                    + new string('~', n - 2) 
                    + "\\" 
                    + new string('.', rightDoths));

                leftDoths++;
                rightDoths--;
            }

            // Middle lower part.

            var leftDothsLower = 0;
            var rightDothsLower = n * 2;

            for (int i = 0; i < (n * 2) + 1; i++)
            {
                Console.WriteLine(
                    new string('.', leftDothsLower) 
                    + "\\" 
                    + new string('.', rightDothsLower)
                    + "|" 
                    + new string('~', n - 2) 
                    + "|");

                leftDothsLower++;
                rightDothsLower--;
            }

            // Bottom part.

            Console.WriteLine(
                new string('.', (n * 2) + 1) 
                + "+" 
                + new string('~', n - 2) 
                + "+");
        }
    }
}