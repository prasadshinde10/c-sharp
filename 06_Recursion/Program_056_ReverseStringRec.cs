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
            Console.WriteLine($"Reversed: {Reverse(text, text.Length - 1)}");
        }

        static string Reverse(string text, int index)
        {
            if (index < 0)
            {
                return string.Empty;
            }

            return text[index] + Reverse(text, index - 1);
        }
    }
}
