namespace _03.Valid_Usernames
{
    using System;
    using System.Text.RegularExpressions;
    public class ValidUsernames
    {
        public static void Main(string[] args)
        {
            string usernames = Console.ReadLine();

            string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";

            Regex regex = new Regex(pattern);
            var matchCollection = regex.Matches(usernames);

            var sum = 0;
            var maxSum = 0;
            string first = string.Empty;
            string second = string.Empty;

            for (int i = 1; i < matchCollection.Count; i++)
            {
                sum = matchCollection[i - 1].Length + matchCollection[i].Length;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    first = matchCollection[i - 1].ToString();
                    second = matchCollection[i].ToString();
                }
            }

            Console.WriteLine($"{first}\n{second}");
        }
    }
}
