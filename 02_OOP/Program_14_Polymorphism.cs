// ============================================
// Program #14 — Polymorphism
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Uses overridden Area methods in Circle and Rectangle classes.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public override double Area() => Math.PI * Radius * Radius;
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area() => Width * Height;
    }

    class Program_14_Polymorphism
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(3);
            Shape rectangle = new Rectangle(4, 5);

            Console.WriteLine($"Circle area: {circle.Area():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.Area():F2}");
        }
    }
}
