// ============================================
// Program #28 — StackQueueDemo
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Demonstrates basic stack and queue operations.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_28_StackQueueDemo
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine($"Stack pop: {stack.Pop()}");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            Console.WriteLine($"Queue dequeue: {queue.Dequeue()}");
        }
    }
}
