// ============================================
// Program #207 — NullRefException
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Preventing NullReferenceException through null checks
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class Customer
    {
        public string? Name { get; set; }
    }

    class Program_207_NullRefException
    {
        static void Main(string[] args)
        {
            Customer? customer = null;

            string displayName = customer?.Name ?? "Guest";
            Console.WriteLine("Safe customer name: " + displayName);

            customer = new Customer { Name = "Aarav" };
            displayName = customer?.Name ?? "Guest";
            Console.WriteLine("Safe customer name: " + displayName);
        }
    }
}
