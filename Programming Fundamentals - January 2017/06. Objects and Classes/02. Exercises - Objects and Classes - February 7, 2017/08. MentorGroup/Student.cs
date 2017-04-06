namespace _08.MentorGroup
{
    using System;
    using System.Collections.Generic;

    class Student
    {
        public string Name { get; set; }

        public List<string> StudentReports { get; set; }

        public List<DateTime> StudentActivities { get; set; }

        public Student(string name, List<string> studentReports, List<DateTime> studentActivities)
        {
            this.Name = name;
            this.StudentReports = studentReports;
            this.StudentActivities = studentActivities;
        }
    }
}