// ============================================
// Program #182 — AbstractFactory
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Abstract factory classes creating multiple concrete products
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    interface INotifier
    {
        void Send(string message);
    }

    abstract class NotificationFactory
    {
        public abstract INotifier CreateNotifier();
    }

    class EmailNotifier : INotifier
    {
        public void Send(string message) => Console.WriteLine($"Email sent: {message}");
    }

    class SmsNotifier : INotifier
    {
        public void Send(string message) => Console.WriteLine($"SMS sent: {message}");
    }

    class EmailFactory : NotificationFactory
    {
        public override INotifier CreateNotifier() => new EmailNotifier();
    }

    class SmsFactory : NotificationFactory
    {
        public override INotifier CreateNotifier() => new SmsNotifier();
    }

    class Program_182_AbstractFactory
    {
        static void Main(string[] args)
        {
            NotificationFactory emailFactory = new EmailFactory();
            NotificationFactory smsFactory = new SmsFactory();

            emailFactory.CreateNotifier().Send("Welcome to our platform");
            smsFactory.CreateNotifier().Send("Your OTP is 123456");
        }
    }
}
