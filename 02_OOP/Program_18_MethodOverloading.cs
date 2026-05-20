// ============================================
// Program #18 — MethodOverloading
// Category  : 02_OOP
// Difficulty: Basic
// Description: Uses overloaded Add methods in a Calculator class.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class MathCalculator
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
    }

    class Program_18_MethodOverloading
    {
        static void Main(string[] args)
        {
            MathCalculator calc = new MathCalculator();
            Console.WriteLine($"Add(int, int): {calc.Add(2, 3)}");
            Console.WriteLine($"Add(double, double): {calc.Add(2.5, 3.1)}");
            Console.WriteLine($"Add(int, int, int): {calc.Add(1, 2, 3)}");
        }
    }
}
