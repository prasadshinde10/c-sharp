// ============================================
// Program #188 — IEnumerableDemo
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Custom collection implementing IEnumerable
// ============================================

using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp30Programs.Advanced_OOP
{
    class NumberCollection : IEnumerable<int>
    {
        private readonly List<int> _numbers = new List<int>();

        public void Add(int number) => _numbers.Add(number);

        public IEnumerator<int> GetEnumerator() => _numbers.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class Program_188_IEnumerableDemo
    {
        static void Main(string[] args)
        {
            var collection = new NumberCollection();
            collection.Add(10);
            collection.Add(20);
            collection.Add(30);

            Console.WriteLine("Iterating custom collection:");
            foreach (int number in collection)
            {
                Console.WriteLine(number);
            }
        }
    }
}
