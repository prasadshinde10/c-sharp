// ============================================
// Program #13 — Inheritance
// Category  : 02_OOP
// Difficulty: Basic
// Description: Shows inheritance with Animal base class and Dog derived class.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Program_13_Inheritance
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.Speak();
        }
    }
}
