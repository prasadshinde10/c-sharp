// ============================================
// Program #06 — FibonacciLoop
// Category  : 01_Basics
// Difficulty: Basic
// Description: Prints the first 10 Fibonacci numbers using a loop.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_06_FibonacciLoop
    {
        static void Main(string[] args)
        {
            int n = 10;
            int first = 0;
            int second = 1;

            Console.Write("Fibonacci: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(first + (i < n - 1 ? ", " : ""));
                int next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine();
        }
    }
}
