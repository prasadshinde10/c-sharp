// ============================================
// Program #23 — LinqBasics
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Filters and orders numbers using LINQ.
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs.Intermediate
{
    class Program_23_LinqBasics
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 5, 8, 20, 3, 15 };
            var result = numbers.Where(n => n > 7).OrderBy(n => n);
            Console.WriteLine("Numbers greater than 7: " + string.Join(", ", result));
        }
    }
}
