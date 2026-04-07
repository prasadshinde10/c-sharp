// ============================================
// Program #053 — SumOfDigits
// Category  : 06_Recursion
// Difficulty: Basic
// Description: Sum of digits of a number recursively
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_053_SumOfDigits
    {
        static void Main(string[] args)
        {
            int number = 12345;
            Console.WriteLine($"Sum of digits of {number} is {SumDigits(number)}");
        }

        static int SumDigits(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return (n % 10) + SumDigits(n / 10);
        }
    }
}
