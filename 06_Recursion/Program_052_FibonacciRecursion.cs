// ============================================
// Program #052 — FibonacciRecursion
// Category  : 06_Recursion
// Difficulty: Basic
// Description: Fibonacci series using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_052_FibonacciRecursion
    {
        static void Main(string[] args)
        {
            int terms = 8;
            Console.WriteLine($"First {terms} Fibonacci terms:");

            for (int i = 0; i < terms; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.WriteLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
