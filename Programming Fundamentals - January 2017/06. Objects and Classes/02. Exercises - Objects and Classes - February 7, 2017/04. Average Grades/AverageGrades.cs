namespace _04.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        //// Define a class Student, which holds the following information about students: name, 
        //// list of grades and average grade(calculated property, read-only). A single grade will be 
        //// in range[2…6], e.g. 3.25 or 5.50.
        //// Read a list of students and print the students that have average grade ≥ 5.00 
        //// ordered by name(ascending), then by average grade(descending). 
        //// Print the student name and the calculated average grade.

        //// Example: Input: 3     ->  ->  ->   Output: Diana -> 5.75
        ////                Ivan 3                      Todor -> 5.33
        ////                Todor 5 5 6
        ////                Diana 6 5.50

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var students = new List<Student>();
            
            for (int i = 0; i < n; i++)
            {
                // Reads the data parts.
                var data = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                // Add each element behind its data index.
                var name = data[0];
                var grades = new List<double>();
                for (int j = 1; j < data.Count; j++)
                {
                    grades.Add(double.Parse(data[j]));
                }

                var average = grades.Average();

                // Add the elements in new class.
                var st = new Student() { Name = name, Grades = grades, AverageGrade = average };

                // Add the new class with the elements in the first List of the class.
                students.Add(st);
            }

            // New list of class -> distinguishes the best students.
            var bestStudents = new List<Student>();

            bestStudents = students
                .Where(s => s.AverageGrade >= 5)
                .OrderByDescending(s => s.AverageGrade)
                .OrderBy(s => s.Name)
                .ToList();

            // Reads the Name and the Average Grade of the best students.
            foreach (var s in bestStudents)
            {
                Console.WriteLine("{0} -> {1:F2}", s.Name, s.AverageGrade);
            }
        }
    }
}