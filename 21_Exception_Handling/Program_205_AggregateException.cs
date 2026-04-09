// ============================================
// Program #205 — AggregateException
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: Handling AggregateException from parallel tasks using Flatten
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.Exception_Handling
{
    class Program_205_AggregateException
    {
        static void Main(string[] args)
        {
            try
            {
                Parallel.Invoke(
                    () => throw new InvalidOperationException("Task 1 failed."),
                    () => throw new ArgumentException("Task 2 failed."));
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("AggregateException caught:");
                foreach (var inner in ex.Flatten().InnerExceptions)
                {
                    Console.WriteLine($"- {inner.GetType().Name}: {inner.Message}");
                }
            }
        }
    }
}
