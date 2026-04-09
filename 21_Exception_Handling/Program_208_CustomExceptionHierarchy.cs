// ============================================
// Program #208 — CustomExceptionHierarchy
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Base and derived custom exception hierarchy demo
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class ApplicationBaseException : Exception
    {
        public ApplicationBaseException(string message) : base(message) { }
    }

    class DatabaseException : ApplicationBaseException
    {
        public DatabaseException(string message) : base(message) { }
    }

    class NetworkException : ApplicationBaseException
    {
        public NetworkException(string message) : base(message) { }
    }

    class Program_208_CustomExceptionHierarchy
    {
        static void Main(string[] args)
        {
            try
            {
                throw new DatabaseException("Database connection timed out.");
            }
            catch (ApplicationBaseException ex)
            {
                Console.WriteLine($"Handled by base custom exception: {ex.GetType().Name} - {ex.Message}");
            }
        }
    }
}
