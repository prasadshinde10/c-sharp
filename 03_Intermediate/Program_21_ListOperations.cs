// ============================================
// Program #21 — ListOperations
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Demonstrates create, add, remove, sort, and search operations on a List.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_21_ListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 9 };
            numbers.Add(4);
            numbers.Remove(2);
            numbers.Sort();

            Console.WriteLine("Sorted List: " + string.Join(", ", numbers));
            Console.WriteLine($"Contains 9: {numbers.Contains(9)}");
        }
    }
}
