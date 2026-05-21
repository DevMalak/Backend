using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "malak", Age = 20, Department = "CS", Grade = 90 },
                new Student { Id = 2, Name = "Sara", Age = 22, Department = "IT", Grade = 75 },
                new Student { Id = 3, Name = "Mona", Age = 21, Department = "CS", Grade = 88 },
                new Student { Id = 4, Name = "fatma", Age = 23, Department = "IS", Grade = 60 },
                new Student { Id = 5, Name = "Lina", Age = 20, Department = "IT", Grade = 95 },
                new Student { Id = 6, Name = "reema", Age = 24, Department = "CS", Grade = 70 }
            };

            // Where()
            Console.WriteLine("Students with Grade > 80:");
            var highGrades = students.Where(s => s.Grade > 80);
            foreach (var s in highGrades)
                Console.WriteLine(s.Name);

            Console.WriteLine();

            // Select()
            Console.WriteLine("All Student Names:");
            var names = students.Select(s => s.Name);
            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine();

            // FirstOrDefault()
            Console.WriteLine("First Student in CS Department:");
            var firstCS = students.FirstOrDefault(s => s.Department == "CS");
            if (firstCS != null)
                Console.WriteLine(firstCS.Name);

            Console.WriteLine();

            // OrderByDescending()
            Console.WriteLine("Students Sorted By Grade:");
            var sorted = students.OrderByDescending(s => s.Grade);
            foreach (var s in sorted)
                Console.WriteLine($"{s.Name} - {s.Grade}");

            Console.WriteLine();

            // Average()
            Console.WriteLine($"Average Grade: {students.Average(s => s.Grade)}");

            Console.WriteLine();

            // Count()
            Console.WriteLine($"Number of IT Students: {students.Count(s => s.Department == "IT")}");

            Console.WriteLine();

            // Max 
            var topStudent = students.OrderByDescending(s => s.Grade).First();
            Console.WriteLine($"Top Student: {topStudent.Name}");
        }
    }
}