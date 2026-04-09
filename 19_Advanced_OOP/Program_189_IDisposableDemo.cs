// ============================================
// Program #189 — IDisposableDemo
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: IDisposable implementation with using statement pattern
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    class FileSimulator : IDisposable
    {
        private bool _disposed;

        public FileSimulator()
        {
            Console.WriteLine("Resource acquired.");
        }

        public void Write(string content)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(FileSimulator));

            Console.WriteLine($"Writing: {content}");
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            Console.WriteLine("Resource released.");
        }
    }

    class Program_189_IDisposableDemo
    {
        static void Main(string[] args)
        {
            using (var file = new FileSimulator())
            {
                file.Write("Hello from IDisposable demo.");
            }

            Console.WriteLine("Using block completed.");
        }
    }
}
