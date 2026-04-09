// ============================================
// Program #197 — BuilderPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Builder pattern constructing a complex Pizza object
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Design_Patterns
{
    class Pizza
    {
        public string Size { get; set; } = "Medium";
        public bool Cheese { get; set; }
        public bool Olives { get; set; }
        public bool Mushrooms { get; set; }

        public override string ToString()
        {
            var toppings = new List<string>();
            if (Cheese) toppings.Add("Cheese");
            if (Olives) toppings.Add("Olives");
            if (Mushrooms) toppings.Add("Mushrooms");
            return $"Pizza(Size={Size}, Toppings={string.Join(", ", toppings)})";
        }
    }

    class PizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();

        public PizzaBuilder SetSize(string size)
        {
            _pizza.Size = size;
            return this;
        }

        public PizzaBuilder AddCheese()
        {
            _pizza.Cheese = true;
            return this;
        }

        public PizzaBuilder AddOlives()
        {
            _pizza.Olives = true;
            return this;
        }

        public PizzaBuilder AddMushrooms()
        {
            _pizza.Mushrooms = true;
            return this;
        }

        public Pizza Build() => _pizza;
    }

    class Program_197_BuilderPattern
    {
        static void Main(string[] args)
        {
            var pizza = new PizzaBuilder()
                .SetSize("Large")
                .AddCheese()
                .AddOlives()
                .Build();

            Console.WriteLine(pizza);
        }
    }
}
