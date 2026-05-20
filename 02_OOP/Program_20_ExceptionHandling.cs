// ============================================
// Program #20 — ExceptionHandling
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Uses try/catch with a custom exception.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class Program_20_ExceptionHandling
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be at least 18.");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ValidateAge(16);
                Console.WriteLine("Age is valid.");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Validation failed: {ex.Message}");
            }
        }
    }
}
