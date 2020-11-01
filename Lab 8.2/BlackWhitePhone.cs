using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class BlackWhitePhone : KeyPhone
    {
        public override List<char> AvailableSymbols => new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '+'};
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public double ScreenSize { get; set; }
        public string PhoneColor { get; set; }

        public BlackWhitePhone(string phoneNumber, int screenWidth, int screenHeight, double screenSize, string phoneColor) : base(phoneNumber)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            ScreenSize = screenSize;
            PhoneColor = phoneColor;
        }
        public virtual void SendSMS()
        {
            Console.WriteLine($"СМС сообщение отправлено на номер {EnterNumber()}");
        }

        public virtual void TakeSMS(string senderPhoneNumber)
        {
            Console.WriteLine($"Входящее СМС сообщение от {senderPhoneNumber}");
        }
    }
}
