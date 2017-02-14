namespace _05.Folder_Size
{
    using System;
    using System.IO;

    public class FolderSize
    {
        //// You are given a folder named “TestFolder”. Get the size of all files in the folder, 
        //// which are NOT directories. The result should be written to another text file in Megabytes.

        public static void Main()
        {
            var currentFiles = Directory.GetFiles("PFFD");

            var totalLengh = 0L;

            foreach (var file in currentFiles)
            {
                var fileInfo = new FileInfo(file);
                totalLengh += fileInfo.Length;
            }

            Console.WriteLine(totalLengh / 1024.0 / 1024.0);

           //// Desision with LINQ.

           //// var totalLengh = Directory
           ////     .GetFiles("PFFD")
           ////     .Select(f => new FileInfo(f))
           ////     .Sum(f => f.Length / 1024.0 / 1024.0);

           //// Console.WriteLine(totalLengh);
        }
    }
}