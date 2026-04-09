// ============================================
// Program #201 — TryCatchFinally
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Try/catch/finally with multiple exception types
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class Program_201_TryCatchFinally
    {
        static void Main(string[] args)
        {
            try
            {
                int[] values = { 10, 0 };
                Console.WriteLine("Division result: " + values[0] / values[1]);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught DivideByZeroException: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught IndexOutOfRangeException: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block always executes.");
            }
        }
    }
}
