using System;

namespace StudentInformationApp
{
    struct Student
    {
        public int StudentId;
        public string StudentName;
        public string CourseName;
        public DateTime DateOfBirth;
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int MaxStudents = 5;
            Student[] students = new Student[MaxStudents];

            // Input student information
            for (int i = 0; i < MaxStudents; i++)
            {
                Console.WriteLine($"Enter information for Student {i + 1}:");
                Console.Write("Student Id: ");
                students[i].StudentId = int.Parse(Console.ReadLine());

                Console.Write("Student Name: ");
                students[i].StudentName = Console.ReadLine();

                Console.Write("Course Name: ");
                students[i].CourseName = Console.ReadLine();

                Console.Write("Date of Birth (YYYY-MM-DD): ");
                students[i].DateOfBirth = DateTime.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nStudent Information:");
            for (int i = 0; i < MaxStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                Console.WriteLine($"Student Id: {students[i].StudentId}");
                Console.WriteLine($"Student Name: {students[i].StudentName}");
                Console.WriteLine($"Course Name: {students[i].CourseName}");
                Console.WriteLine($"Date of Birth: {students[i].DateOfBirth.ToShortDateString()}");
                Console.WriteLine();
            }
        }
    }
}
