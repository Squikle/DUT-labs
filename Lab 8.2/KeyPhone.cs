using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class KeyPhone : RotaryPhone
    {
        public override List<char> AvailableSymbols => new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#'};

        public KeyPhone(string phoneNumber) : base(phoneNumber)
        { }
        public override void TakeCall(string callingPhoneNumber)
        {
            Console.WriteLine($"Входящий вызов с номера {callingPhoneNumber}");
        }
    }
}
