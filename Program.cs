using System;

namespace StudentReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(
                "Swapnil Kulkarni",
                "R102",
                new int[] { 78, 85, 90, 88, 76 }
            );

            Console.WriteLine(student.ToString());
        }
    }
}
