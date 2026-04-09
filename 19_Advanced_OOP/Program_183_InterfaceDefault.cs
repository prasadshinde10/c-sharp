// ============================================
// Program #183 — InterfaceDefault
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Interface default method implementation in C# 8+
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    interface ILogger
    {
        void LogError(string message);

        void LogInfo(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }
    }

    class ApplicationLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }
    }

    class Program_183_InterfaceDefault
    {
        static void Main(string[] args)
        {
            ILogger logger = new ApplicationLogger();
            logger.LogInfo("Application started using default interface method.");
            logger.LogError("A sample error occurred.");
        }
    }
}
