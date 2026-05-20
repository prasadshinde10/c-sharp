// ============================================
// Program #27 — GenericMethod
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Uses a generic method to print different data types.
// ============================================

using System;

namespace CSharp30Programs.Intermediate
{
    class Program_27_GenericMethod
    {
        static void PrintValue<T>(T value)
        {
            Console.WriteLine($"Value: {value}");
        }

        static void Main(string[] args)
        {
            PrintValue(100);
            PrintValue("Generic method");
            PrintValue(45.67);
        }
    }
}
