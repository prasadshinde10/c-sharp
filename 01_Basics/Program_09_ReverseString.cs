// ============================================
// Program #09 — ReverseString
// Category  : 01_Basics
// Difficulty: Basic
// Description: Reverses a string entered by the user.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_09_ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine() ?? string.Empty;
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine($"Reversed: {new string(chars)}");
        }
    }
}
