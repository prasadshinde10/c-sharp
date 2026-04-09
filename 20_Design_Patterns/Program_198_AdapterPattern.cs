// ============================================
// Program #198 — AdapterPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Adapter pattern bridging incompatible interfaces
// ============================================

using System;

namespace CSharp30Programs.Design_Patterns
{
    interface IUsbCharger
    {
        void ChargeWithUsb();
    }

    class OldPinCharger
    {
        public void ChargeWithOldPin()
        {
            Console.WriteLine("Charging with old pin charger.");
        }
    }

    class ChargerAdapter : IUsbCharger
    {
        private readonly OldPinCharger _oldPinCharger;

        public ChargerAdapter(OldPinCharger oldPinCharger)
        {
            _oldPinCharger = oldPinCharger;
        }

        public void ChargeWithUsb()
        {
            Console.WriteLine("Adapter converts USB to old pin.");
            _oldPinCharger.ChargeWithOldPin();
        }
    }

    class Program_198_AdapterPattern
    {
        static void Main(string[] args)
        {
            IUsbCharger charger = new ChargerAdapter(new OldPinCharger());
            charger.ChargeWithUsb();
        }
    }
}
