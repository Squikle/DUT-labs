using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class RotaryPhone
    {
        public string PhoneNumber { get; set; }
        public virtual List<char> AvailableSymbols => new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public RotaryPhone(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        protected string EnterNumber()
        {
            Console.Write("Введите номер абонента: ");
            while (true)
            {
                bool invalid = false;
                string number = Console.ReadLine();
                foreach (char symbol in number)
                    if (!AvailableSymbols.Contains(symbol))
                    {
                        invalid = true;
                        break;
                    }
                if (invalid)
                {
                    Console.Write("Некорректный ввод. Попробуйте снова: ");
                    continue;
                }
                return number;
            }
        }
        public virtual void Call()
        {
            Console.WriteLine($"Звонок на номер {EnterNumber()}");
        }
        public virtual void TakeCall(string callingPhoneNumber)
        {
            Console.WriteLine($"Входящий вызов");
        }
    }
}
