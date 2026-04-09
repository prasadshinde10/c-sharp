// ============================================
// Program #202 — CustomException
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Custom exception class carrying additional properties
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class ValidationException : Exception
    {
        public int ErrorCode { get; }

        public ValidationException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }

    class Program_202_CustomException
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ValidationException("Invalid age value.", 1001);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine($"Custom exception caught: {ex.Message} (Code: {ex.ErrorCode})");
            }
        }
    }
}
