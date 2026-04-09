// ============================================
// Program #192 — FactoryPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Factory method pattern creating different shapes
// ============================================

using System;

namespace CSharp30Programs.Design_Patterns
{
    interface IShape
    {
        void Draw();
    }

    class Circle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a circle.");
    }

    class Rectangle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a rectangle.");
    }

    static class ShapeFactory
    {
        public static IShape CreateShape(string type)
        {
            return type.ToLower() switch
            {
                "circle" => new Circle(),
                "rectangle" => new Rectangle(),
                _ => throw new ArgumentException("Unknown shape type")
            };
        }
    }

    class Program_192_FactoryPattern
    {
        static void Main(string[] args)
        {
            IShape shape1 = ShapeFactory.CreateShape("circle");
            IShape shape2 = ShapeFactory.CreateShape("rectangle");

            shape1.Draw();
            shape2.Draw();
        }
    }
}
