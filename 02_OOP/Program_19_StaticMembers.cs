// ============================================
// Program #19 — StaticMembers
// Category  : 02_OOP
// Difficulty: Basic
// Description: Counts objects using a static class member.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Counter
    {
        public static int Count { get; private set; }

        public Counter()
        {
            Count++;
        }
    }

    class Program_19_StaticMembers
    {
        static void Main(string[] args)
        {
            _ = new Counter();
            _ = new Counter();
            _ = new Counter();

            Console.WriteLine($"Objects created: {Counter.Count}");
        }
    }
}
