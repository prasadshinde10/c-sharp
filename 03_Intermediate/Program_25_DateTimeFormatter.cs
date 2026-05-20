// ============================================
// Program #25 — DateTimeFormatter
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Displays current date and time in custom formats.
// ============================================

using System;

namespace CSharp30Programs.Intermediate
{
    class Program_25_DateTimeFormatter
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Default: {now}");
            Console.WriteLine($"Date: {now:dd-MM-yyyy}");
            Console.WriteLine($"Time: {now:HH:mm:ss}");
        }
    }
}
