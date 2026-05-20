// ============================================
// Program #12 — Constructors
// Category  : 02_OOP
// Difficulty: Basic
// Description: Demonstrates default and parameterized constructors.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Student
    {
        public string Name { get; }

        public Student()
        {
            Name = "Unknown";
        }

        public Student(string name)
        {
            Name = name;
        }
    }

    class Program_12_Constructors
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Aarav");

            Console.WriteLine($"Default constructor: {s1.Name}");
            Console.WriteLine($"Parameterized constructor: {s2.Name}");
        }
    }
}
