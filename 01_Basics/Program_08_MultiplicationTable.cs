// ============================================
// Program #08 — MultiplicationTable
// Category  : 01_Basics
// Difficulty: Basic
// Description: Prints a multiplication table for a given number.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_08_MultiplicationTable
    {
        static void Main(string[] args)
        {
            int number = 7;
            Console.WriteLine($"Multiplication table for {number}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
