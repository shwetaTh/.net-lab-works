using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public string Program { get; set; }
    public char Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Program = "BCA", Grade = 'A' },
            new Student { Name = "Bob", Program = "BBA", Grade = 'B' },
            new Student { Name = "Charlie", Program = "BCA", Grade = 'A' },
            new Student { Name = "David", Program = "MBA", Grade = 'A' },
            new Student { Name = "Eva", Program = "BCA", Grade = 'C' }
        };
        var result = from student in students
                     where student.Grade == 'A' && student.Program == "BCA"
                     select student;
        Console.WriteLine("Students with grade 'A' and program 'BCA':");
        foreach (var student in result)
        {
            Console.WriteLine($"Name: {student.Name}, Program: {student.Program}, Grade: {student.Grade}");
        }
    }
}
