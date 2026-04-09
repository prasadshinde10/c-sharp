// ============================================
// Program #187 — IComparableDemo
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: IComparable implementation for sorting custom objects
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Advanced_OOP
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; } = string.Empty;
        public int Score { get; set; }

        public int CompareTo(Student? other)
        {
            if (other is null) return 1;
            return Score.CompareTo(other.Score);
        }
    }

    class Program_187_IComparableDemo
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student { Name = "Asha", Score = 78 },
                new Student { Name = "Karan", Score = 92 },
                new Student { Name = "Neha", Score = 85 }
            };

            students.Sort();

            Console.WriteLine("Students sorted by score:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Score}");
            }
        }
    }
}
