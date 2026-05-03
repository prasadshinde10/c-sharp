// ============================================
// Program #10 — PalindromeCheck
// Category  : 01_Basics
// Difficulty: Basic
// Description: Check if a string is a palindrome ignoring case and spaces
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_10_PalindromeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine() ?? string.Empty;

            string cleaned = string.Empty;
            foreach (char ch in input)
            {
                if (!char.IsWhiteSpace(ch))
                {
                    cleaned += char.ToLower(ch);
                }
            }

            char[] chars = cleaned.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            bool isPalindrome = cleaned == reversed;
            Console.WriteLine(isPalindrome
                ? "The string is a palindrome."
                : "The string is not a palindrome.");
        }
    }
}
