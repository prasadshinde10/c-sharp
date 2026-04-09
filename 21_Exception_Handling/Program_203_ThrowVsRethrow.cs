// ============================================
// Program #203 — ThrowVsRethrow
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Difference between throw and throw ex for stack trace
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class Program_203_ThrowVsRethrow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo 1: throw ex (resets stack trace)");
            try
            {
                ThrowExDemo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace?.Split(Environment.NewLine)[0]);
            }

            Console.WriteLine("\nDemo 2: throw (preserves stack trace)");
            try
            {
                RethrowDemo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace?.Split(Environment.NewLine)[0]);
            }
        }

        static void CauseFailure() => throw new InvalidOperationException("Original failure");

        static void ThrowExDemo()
        {
            try
            {
                CauseFailure();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void RethrowDemo()
        {
            try
            {
                CauseFailure();
            }
            catch
            {
                throw;
            }
        }
    }
}
