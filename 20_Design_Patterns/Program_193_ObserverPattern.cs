// ============================================
// Program #193 — ObserverPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Observer pattern with subject and multiple observers
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Design_Patterns
{
    interface IObserver
    {
        void Update(string message);
    }

    class Subscriber : IObserver
    {
        private readonly string _name;

        public Subscriber(string name) => _name = name;

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received: {message}");
        }
    }

    class NewsPublisher
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer) => _observers.Add(observer);

        public void Notify(string news)
        {
            foreach (var observer in _observers)
                observer.Update(news);
        }
    }

    class Program_193_ObserverPattern
    {
        static void Main(string[] args)
        {
            var publisher = new NewsPublisher();
            publisher.Subscribe(new Subscriber("Alice"));
            publisher.Subscribe(new Subscriber("Bob"));

            publisher.Notify("Observer pattern implemented successfully.");
        }
    }
}
