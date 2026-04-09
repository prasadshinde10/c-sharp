// ============================================
// Program #209 — UsingStatement
// Category  : 21_Exception_Handling
// Difficulty: [Intermediate]
// Description: using statement and using declaration for safe disposal
// ============================================

using System;

namespace CSharp30Programs.Exception_Handling
{
    class DemoResource : IDisposable
    {
        private readonly string _name;

        public DemoResource(string name)
        {
            _name = name;
            Console.WriteLine($"{_name} acquired.");
        }

        public void Work()
        {
            Console.WriteLine($"{_name} is working.");
        }

        public void Dispose()
        {
            Console.WriteLine($"{_name} disposed.");
        }
    }

    class Program_209_UsingStatement
    {
        static void Main(string[] args)
        {
            using (var resource1 = new DemoResource("Using statement resource"))
            {
                resource1.Work();
            }

            using var resource2 = new DemoResource("Using declaration resource");
            resource2.Work();

            Console.WriteLine("End of method triggers disposal for using declaration.");
        }
    }
}
