namespace _01.Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        // Write a program, which reads the name of a student and their grades and adds them 
        // to the student record, then prints grades along with their average grade.

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var nameAndGrade = Console.ReadLine().Split(' ');
                var name = nameAndGrade[0];
                var grade = double.Parse(nameAndGrade[1]);

                if (!grades.ContainsKey(name)) // 2
                    grades[name] = new List<double>(); // 3
                    grades[name].Add(grade); // 1
                
            }

            foreach (var nameAndGrades in grades)
            {
                Console.WriteLine("{0} -> {1} (avg: {2:F2})",
                    nameAndGrades.Key,
                    string.Join(" ", nameAndGrades.Value.Select(p => string.Format("{0:f2}", p))),
                    nameAndGrades.Value.Average());
            }
        }
    }
}