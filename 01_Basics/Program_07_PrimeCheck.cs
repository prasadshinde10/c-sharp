// ============================================
// Program #07 — PrimeCheck
// Category  : 01_Basics
// Difficulty: Basic
// Description: Checks whether a number is prime.
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_07_PrimeCheck
    {
        static void Main(string[] args)
        {
            int number = 29;
            bool isPrime = number > 1;

            for (int i = 2; i * i <= number && isPrime; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine(isPrime
                ? $"{number} is a prime number."
                : $"{number} is not a prime number.");
        }
    }
}
