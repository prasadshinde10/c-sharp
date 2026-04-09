// ============================================
// Program #200 — IteratorPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Iterator pattern for custom collection traversal
// ============================================

using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp30Programs.Design_Patterns
{
    class NameCollection : IEnumerable<string>
    {
        private readonly List<string> _names = new List<string>();

        public void Add(string name) => _names.Add(name);

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var name in _names)
                yield return name;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class Program_200_IteratorPattern
    {
        static void Main(string[] args)
        {
            var names = new NameCollection();
            names.Add("Anaya");
            names.Add("Dev");
            names.Add("Ira");

            Console.WriteLine("Traversing custom collection:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
