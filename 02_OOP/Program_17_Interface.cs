// ============================================
// Program #17 — Interface
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Demonstrates interface implementation for payment methods.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    interface IPayment
    {
        void Pay(decimal amount);
    }

    class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }

    class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }

    class Program_17_Interface
    {
        static void Main(string[] args)
        {
            IPayment card = new CreditCardPayment();
            IPayment paypal = new PayPalPayment();
            card.Pay(499.99m);
            paypal.Pay(129.50m);
        }
    }
}
