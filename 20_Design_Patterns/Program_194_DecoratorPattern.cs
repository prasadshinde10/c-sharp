// ============================================
// Program #194 — DecoratorPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Decorator pattern adding features to a coffee order
// ============================================

using System;

namespace CSharp30Programs.Design_Patterns
{
    interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    class SimpleCoffee : ICoffee
    {
        public string GetDescription() => "Simple Coffee";
        public double GetCost() => 50;
    }

    abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee Coffee;

        protected CoffeeDecorator(ICoffee coffee) => Coffee = coffee;

        public virtual string GetDescription() => Coffee.GetDescription();
        public virtual double GetCost() => Coffee.GetCost();
    }

    class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => Coffee.GetDescription() + ", Milk";
        public override double GetCost() => Coffee.GetCost() + 20;
    }

    class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => Coffee.GetDescription() + ", Sugar";
        public override double GetCost() => Coffee.GetCost() + 10;
    }

    class Program_194_DecoratorPattern
    {
        static void Main(string[] args)
        {
            ICoffee order = new SimpleCoffee();
            order = new MilkDecorator(order);
            order = new SugarDecorator(order);

            Console.WriteLine($"Order: {order.GetDescription()}");
            Console.WriteLine($"Cost : {order.GetCost()}");
        }
    }
}
