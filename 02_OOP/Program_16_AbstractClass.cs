// ============================================
// Program #16 — AbstractClass
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Implements an abstract Vehicle class with concrete subclasses.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    abstract class Vehicle
    {
        public abstract void Start();
    }

    class CarVehicle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car engine started.");
        }
    }

    class BikeVehicle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike engine started.");
        }
    }

    class Program_16_AbstractClass
    {
        static void Main(string[] args)
        {
            Vehicle car = new CarVehicle();
            Vehicle bike = new BikeVehicle();
            car.Start();
            bike.Start();
        }
    }
}
