// ============================================
// Program #184 — MultipleInterfaces
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Class implementing multiple interfaces together
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    interface IDrive
    {
        void Drive();
    }

    interface IFly
    {
        void Fly();
    }

    class FlyingCar : IDrive, IFly
    {
        public void Drive() => Console.WriteLine("Driving on the road.");
        public void Fly() => Console.WriteLine("Flying in the sky.");
    }

    class Program_184_MultipleInterfaces
    {
        static void Main(string[] args)
        {
            var vehicle = new FlyingCar();
            vehicle.Drive();
            vehicle.Fly();
        }
    }
}
