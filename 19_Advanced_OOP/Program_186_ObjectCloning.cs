// ============================================
// Program #186 — ObjectCloning
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Shallow copy vs deep copy for object cloning
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    class Address
    {
        public string City { get; set; } = string.Empty;
    }

    class Employee : ICloneable
    {
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();

        public object Clone() => MemberwiseClone();

        public Employee DeepCopy()
        {
            return new Employee
            {
                Name = Name,
                Address = new Address { City = Address.City }
            };
        }
    }

    class Program_186_ObjectCloning
    {
        static void Main(string[] args)
        {
            var original = new Employee { Name = "Riya", Address = new Address { City = "Pune" } };
            var shallowCopy = (Employee)original.Clone();
            var deepCopy = original.DeepCopy();

            original.Address.City = "Mumbai";

            Console.WriteLine($"Original city: {original.Address.City}");
            Console.WriteLine($"Shallow copy city: {shallowCopy.Address.City}");
            Console.WriteLine($"Deep copy city: {deepCopy.Address.City}");
        }
    }
}
