// ============================================
// Program #29 — StringBuilderDemo
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Builds and edits text using StringBuilder.
// ============================================

using System;
using System.Text;

namespace CSharp30Programs.Intermediate
{
    class Program_29_StringBuilderDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("C#");
            sb.Append(" ");
            sb.Append("StringBuilder");
            sb.Replace("StringBuilder", "Builder");

            Console.WriteLine(sb.ToString());
        }
    }
}
