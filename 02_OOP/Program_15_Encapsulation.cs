// ============================================
// Program #15 — Encapsulation
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Demonstrates encapsulation in a BankAccount class.
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            _balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }

        public decimal GetBalance() => _balance;
    }

    class Program_15_Encapsulation
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);
            account.Deposit(250);
            account.Withdraw(400);
            Console.WriteLine($"Current balance: {account.GetBalance()}");
        }
    }
}
