// ============================================
// Program #03 — ArithmeticOps
// Category  : 01_Basics
// Difficulty: Basic
// Description: Performs add, subtract, multiply, and divide on two numbers.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_03_ArithmeticOps
    {
        static void Main(string[] args)
        {
            double a = 20;
            double b = 5;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
        }
    }
}
