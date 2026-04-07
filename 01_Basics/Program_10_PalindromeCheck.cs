// ============================================
// Program #10 — PalindromeCheck
// Category  : 01_Basics
// Difficulty: Basic
// Description: Checks whether an input string is a palindrome.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_10_PalindromeCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            char[] chars = input.ToLowerInvariant().ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            bool isPalindrome = input.ToLowerInvariant() == reversed;

            Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
        }
    }
}
