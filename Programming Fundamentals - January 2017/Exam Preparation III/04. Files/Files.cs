namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Files
    {
        public static void Main()
        {
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var routeParams = Console.ReadLine().Split('\\').ToArray();

                var root = routeParams[0];
                var fileWithSize = routeParams[routeParams.Length - 1].Split(';');

                var fileWithExtention = fileWithSize[0];
                var fileSize = long.Parse(fileWithSize[1]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, long>());
                }

                if (!filesByRoot[root].ContainsKey(fileWithExtention))
                {
                    filesByRoot[root].Add(fileWithExtention, fileSize);
                }
                else
                {
                    filesByRoot[root][fileWithExtention] = fileSize;
                }
            }

            var queryParams = Console.ReadLine()
                .Split(' ').ToArray();

            var queryExtension = queryParams[0];
            var queryRoot = queryParams[2];

            if (filesByRoot.ContainsKey(queryRoot))
            {
                Dictionary<string, long> filesFound = filesByRoot[queryRoot];

                foreach (var file in filesFound.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(queryExtension))
                    {
                        Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}