// ============================================
// Program #11 — ClassAndObject
// Category  : 02_OOP
// Difficulty: Basic
// Description: Creates a Car class with properties and a method.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Car
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }
    }

    class Program_11_ClassAndObject
    {
        static void Main(string[] args)
        {
            Car car = new Car { Brand = "Toyota", Model = "Corolla" };
            car.DisplayInfo();
        }
    }
}
