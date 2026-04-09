// ============================================
// Program #191 — SingletonPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Singleton pattern with private constructor and static instance
// ============================================

using System;

namespace CSharp30Programs.Design_Patterns
{
    sealed class LoggerSingleton
    {
        private static readonly LoggerSingleton _instance = new LoggerSingleton();

        private LoggerSingleton() { }

        public static LoggerSingleton Instance => _instance;

        public void Log(string message) => Console.WriteLine($"[Singleton] {message}");
    }

    class Program_191_SingletonPattern
    {
        static void Main(string[] args)
        {
            var logger1 = LoggerSingleton.Instance;
            var logger2 = LoggerSingleton.Instance;

            Console.WriteLine($"Same instance: {ReferenceEquals(logger1, logger2)}");
            logger1.Log("Application initialized.");
        }
    }
}
