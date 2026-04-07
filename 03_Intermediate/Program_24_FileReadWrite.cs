// ============================================
// Program #24 — FileReadWrite
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Writes text to a file and reads it back.
// ============================================

using System;
using System.IO;

namespace CSharp30Programs.Intermediate
{
    class Program_24_FileReadWrite
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "sample_csharp_program_24.txt");
            File.WriteAllText(filePath, "C# file I/O example.");
            string content = File.ReadAllText(filePath);
            Console.WriteLine($"Read from file: {content}");
        }
    }
}
