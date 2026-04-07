// ============================================
// Program #05 — Calculator
// Category  : 01_Basics
// Difficulty: Basic
// Description: Runs a simple switch-based calculator for two numbers.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_05_Calculator
    {
        static void Main(string[] args)
        {
            double num1 = 12;
            double num2 = 3;
            char op = '*';
            double result;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num2 != 0 ? num1 / num2 : double.NaN;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"{num1} {op} {num2} = {result}");
        }
    }
}
