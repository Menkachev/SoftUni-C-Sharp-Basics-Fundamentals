namespace _19.Thea_The_Photographer
{
    using System;

    public class TheaThePhotographer
    {
        //// This problem is from the Programming Fundamentals Retake Exam (11 September 2016).

        //// Thea is a photographer.She takes pictures of people on special events. 
        //// She is a good friend and you want to help her. She wants to inform her 
        //// clients when their pictures will be ready. Since the number of pictures 
        //// is big and it requires time for editing (#nofilter, #allnatural) every 
        //// single picture - you decide to write a program in order to help her.

        //// Thea follows this pattern: first she takes all pictures. Then she goes 
        //// through every single picture to filter these pictures that are considered "good". 
        //// Then she needs to upload every single filtered picture to her cloud. She is considered 
        //// ready when all filtered pictures are uploaded in her picture storage. 

        //// You will receive the amount of pictures she had taken. Then the approximate time in seconds 
        //// for every picture to be filtered. Then a filter factor – a percentage (integer number) 
        //// of the total photos(rounded to the nearest bigger integer value e.g. 5.01 -> 6) that are 
        //// good enough to be given to her clients (Photoshop may do miracles but Thea does not). 
        //// Approximate time for every picture to be uploaded will be given again in seconds.
        //// Your task is: based on this input to display total time needed for her to be ready 
        //// with the pictures in given below format.

        public static void Main()
        {
            int takenPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterPercentage = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int filteredPictures = takenPictures * filterTime;
            int percentageOfGoodPictures = (int)Math.Ceiling(takenPictures * ((double)filterPercentage / 100));
            int timeForUploadPerPicture = percentageOfGoodPictures * uploadTime;

            var totalTime = filteredPictures + timeForUploadPerPicture;

            var time = new TimeSpan(0, 0, totalTime);

            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}