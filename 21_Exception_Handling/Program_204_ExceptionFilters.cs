// ============================================
// Program #204 — ExceptionFilters
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Exception filters using when clause in catch blocks
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class Program_204_ExceptionFilters
    {
        static void Main(string[] args)
        {
            HandleError("WARN");
            HandleError("CRITICAL");
        }

        static void HandleError(string level)
        {
            try
            {
                throw new Exception($"{level}: service response delayed");
            }
            catch (Exception ex) when (ex.Message.StartsWith("WARN"))
            {
                Console.WriteLine("Warning handled without escalation.");
            }
            catch (Exception ex) when (ex.Message.StartsWith("CRITICAL"))
            {
                Console.WriteLine("Critical issue escalated: " + ex.Message);
            }
        }
    }
}
