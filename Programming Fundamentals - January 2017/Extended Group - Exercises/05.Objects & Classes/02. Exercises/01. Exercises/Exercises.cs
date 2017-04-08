namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercises
    {
        public static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();

            string inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                var inputParams = inputLine
                    .Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var topic = inputParams[0];
                var courseName = inputParams[1];
                var judgeContentLink = inputParams[2];
                List<string> problems = inputParams.Skip(3).ToList();

                Exercise newExercises = new Exercise();

                newExercises.Topic = topic;
                newExercises.CourseName = courseName;
                newExercises.JudgeContestLink = judgeContentLink;
                newExercises.Problems = problems;

                exercises.Add(newExercises);

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                int count = 1;

                foreach (var porblem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {porblem}");
                    count++;
                }
            }
        }
    }
}