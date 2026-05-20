// ============================================
// Program #04 — EvenOdd
// Category  : 01_Basics
// Difficulty: Basic
// Description: Checks whether a number is even or odd.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_04_EvenOdd
    {
        static void Main(string[] args)
        {
            int number = 17;
            string result = number % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine($"{number} is {result}.");
        }
    }
}
