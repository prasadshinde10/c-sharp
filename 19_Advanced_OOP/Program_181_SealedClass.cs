// ============================================
// Program #181 — SealedClass
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Sealed class preventing inheritance with demo usage
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    sealed class MathUtility
    {
        public int Add(int a, int b) => a + b;
    }

    class Program_181_SealedClass
    {
        static void Main(string[] args)
        {
            var utility = new MathUtility();
            int result = utility.Add(12, 8);
            Console.WriteLine($"Sealed class demo: 12 + 8 = {result}");
        }
    }
}
