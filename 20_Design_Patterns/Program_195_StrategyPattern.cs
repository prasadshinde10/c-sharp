// ============================================
// Program #195 — StrategyPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Strategy pattern for interchangeable sorting algorithms
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs.Design_Patterns
{
    interface ISortStrategy
    {
        int[] Sort(int[] input);
    }

    class AscendingSort : ISortStrategy
    {
        public int[] Sort(int[] input) => input.OrderBy(x => x).ToArray();
    }

    class DescendingSort : ISortStrategy
    {
        public int[] Sort(int[] input) => input.OrderByDescending(x => x).ToArray();
    }

    class SortContext
    {
        private ISortStrategy _strategy;

        public SortContext(ISortStrategy strategy) => _strategy = strategy;

        public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;

        public int[] Execute(int[] data) => _strategy.Sort(data);
    }

    class Program_195_StrategyPattern
    {
        static void Main(string[] args)
        {
            int[] data = { 5, 2, 9, 1 };
            var context = new SortContext(new AscendingSort());
            Console.WriteLine("Ascending : " + string.Join(", ", context.Execute(data)));

            context.SetStrategy(new DescendingSort());
            Console.WriteLine("Descending: " + string.Join(", ", context.Execute(data)));
        }
    }
}
