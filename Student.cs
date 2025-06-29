using System;
using System.Linq;

namespace StudentReport
{
    public class Student
    {
        private string studentName;
        private string rollNumber;
        private int[] marks; // size 5

        public Student(string studentName, string rollNumber, int[] marks)
        {
            if (marks == null || marks.Length != 5)
                throw new ArgumentException("Marks array must contain exactly 5 elements.");
          //Console.WriteLine("Marks array must contain exactly 5 elements.");
            this.studentName = studentName;
            this.rollNumber = rollNumber;
            this.marks = marks;
        }

        public double CalculateAverage()
        {
            return marks.Average();
        }

        public string CalculateGrade()
        {
            double avg = CalculateAverage();
            if (avg >= 90) return "A+";
            if (avg >= 80) return "A";
            if (avg >= 70) return "B";
            if (avg >= 60) return "C";
            if (avg >= 50) return "D";
            return "Fail";
        }

        public override string ToString()
        {
            return
$@"Student Report Card
----------------------------
Name        : {studentName}
Roll No     : {rollNumber}
Marks       : [{string.Join(", ", marks)}]
Average     : {CalculateAverage():0.0}
Grade       : {CalculateGrade()}";
        }
    }
}
