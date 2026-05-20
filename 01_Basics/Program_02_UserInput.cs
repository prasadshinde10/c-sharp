// ============================================
// Program #02 — UserInput
// Category  : 01_Basics
// Difficulty: Basic
// Description: Takes name input and greets the user.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_02_UserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "Guest";
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Guest";
            }

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
