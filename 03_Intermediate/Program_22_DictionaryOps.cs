// ============================================
// Program #22 — DictionaryOps
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Counts word frequency using a Dictionary.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_22_DictionaryOps
    {
        static void Main(string[] args)
        {
            string sentence = "apple banana apple orange banana apple";
            Dictionary<string, int> frequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                frequency[word] = frequency.TryGetValue(word, out int count) ? count + 1 : 1;
            }

            foreach (KeyValuePair<string, int> item in frequency)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
