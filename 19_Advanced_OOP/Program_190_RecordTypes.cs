// ============================================
// Program #190 — RecordTypes
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Record types with immutability and with expression
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    record EmployeeRecord(string Name, int Experience);

    class Program_190_RecordTypes
    {
        static void Main(string[] args)
        {
            var original = new EmployeeRecord("Priya", 5);
            var updated = original with { Experience = 6 };

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Updated : {updated}");
        }
    }
}
