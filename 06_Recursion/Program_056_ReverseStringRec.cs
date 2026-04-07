// ============================================
// Program #056 — ReverseStringRec
// Category  : 06_Recursion
// Difficulty: Intermediate
// Description: Reverse a string using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_056_ReverseStringRec
    {
        static void Main(string[] args)
        {
            string text = "recursion";
            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Reversed: {Reverse(text)}");
        }

        static string Reverse(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length == 1)
            {
                return text;
            }
            return Reverse(text.Substring(1)) + text[0];
        }
    }
}
