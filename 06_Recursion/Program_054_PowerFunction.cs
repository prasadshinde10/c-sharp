// ============================================
// Program #054 — PowerFunction
// Category  : 06_Recursion
// Difficulty: Basic
// Description: Calculate x^n using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_054_PowerFunction
    {
        static void Main(string[] args)
        {
            int x = 2;
            int n = 10;
            Console.WriteLine($"{x}^{n} = {Power(x, n)}");
        }

        static long Power(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return x * Power(x, n - 1);
        }
    }
}
