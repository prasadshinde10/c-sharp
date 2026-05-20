// ============================================
// Program #30 — MiniCalculator
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Runs a mini calculator with reusable operation methods.
// ============================================

using System;

namespace CSharp30Programs.Intermediate
{
    class Program_30_MiniCalculator
    {
        static double Calculate(double a, double b, char op)
        {
            return op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero."),
                _ => throw new InvalidOperationException("Unsupported operation.")
            };
        }

        static void Main(string[] args)
        {
            double a = 25;
            double b = 5;
            char op = '/';

            try
            {
                double result = Calculate(a, b, op);
                Console.WriteLine($"{a} {op} {b} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Calculation error: {ex.Message}");
            }
        }
    }
}
