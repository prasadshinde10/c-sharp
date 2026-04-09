// ============================================
// Program #210 — GlobalException
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Global exception handling pattern with AppDomain event
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class Program_210_GlobalException
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

            Console.WriteLine("Global exception handler registered.");
            Console.WriteLine("Executing application logic with top-level protection...");

            try
            {
                SimulateFailure();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Top-level catch handled exception: " + ex.Message);
            }

            Console.WriteLine("Application ended gracefully.");
        }

        static void SimulateFailure()
        {
            throw new InvalidOperationException("Simulated runtime failure.");
        }

        static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("Global handler captured: " + ((Exception)e.ExceptionObject).Message);
        }
    }
}
