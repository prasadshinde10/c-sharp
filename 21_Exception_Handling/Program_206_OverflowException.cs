// ============================================
// Program #206 — OverflowException
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Handling OverflowException using checked keyword
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class Program_206_OverflowException
    {
        static void Main(string[] args)
        {
            try
            {
                int max = int.MaxValue;
                int result = checked(max + 1);
                Console.WriteLine(result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow detected: " + ex.Message);
            }
        }
    }
}
