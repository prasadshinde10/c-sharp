// ============================================
// Program #26 — EnumDemo
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Demonstrates use of enums in C#.
// ============================================

using System;

namespace CSharp30Programs.Intermediate
{
    enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered
    }

    class Program_26_EnumDemo
    {
        static void Main(string[] args)
        {
            OrderStatus status = OrderStatus.Shipped;
            Console.WriteLine($"Current order status: {status}");
            Console.WriteLine($"Underlying value: {(int)status}");
        }
    }
}
