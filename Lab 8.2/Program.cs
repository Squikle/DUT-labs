using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дисковый телефон:");
            RotaryPhone rotaryPhone = new RotaryPhone("111");

            Console.Write("Доступные символы: ");
            foreach (var sym in rotaryPhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {rotaryPhone.PhoneNumber}");
            rotaryPhone.Call();
            rotaryPhone.TakeCall("101");

            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Кнопочный телефон:");
            KeyPhone keyPhone = new KeyPhone("222");

            Console.Write("Доступные символы: ");
            foreach (var sym in keyPhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {keyPhone.PhoneNumber}");
            keyPhone.Call();
            keyPhone.TakeCall("101");

            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Телефон с черно-белым экраном:");
            BlackWhitePhone blackWhitePhone = new BlackWhitePhone("333", 50, 100, 2.9, "Черный");

            Console.Write("Доступные символы: ");
            foreach (var sym in blackWhitePhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {blackWhitePhone.PhoneNumber}");
            Console.WriteLine($"Ширина экрана (пиксели): {blackWhitePhone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {blackWhitePhone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {blackWhitePhone.ScreenSize}");
            Console.WriteLine($"Цвет телефона: {blackWhitePhone.PhoneColor}");
            blackWhitePhone.Call();
            blackWhitePhone.TakeCall("101");
            blackWhitePhone.SendSMS();
            blackWhitePhone.TakeSMS("101");


            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Телефон с цветным экраном:");
            ColorPhone colorPhone = new ColorPhone("444", 200, 400, 3.2, "Черный", 16000000, "445");

            Console.Write("Доступные символы: ");
            foreach (var sym in colorPhone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {colorPhone.PhoneNumber}");
            Console.WriteLine($"Ширина экрана (пиксели): {colorPhone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {colorPhone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {colorPhone.ScreenSize}");
            Console.WriteLine($"Цвет телефона: {colorPhone.PhoneColor}");
            Console.WriteLine($"Количество сим-карт: {(colorPhone.TwoSIM ? 2 : 1)}");
            Console.WriteLine($"Второй номер: {(colorPhone.TwoSIM ? colorPhone.SecondaryPhoneNumber : "-")}");
            colorPhone.Call();
            colorPhone.TakeCall("101");
            colorPhone.SendSMS();
            colorPhone.TakeSMS("101");
            colorPhone.SendMMS();
            colorPhone.TakeMMS("101");


            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Смартфон:");
            Smartphone smartphone = new Smartphone("555", 1080, 1920, 6.28, "Черный", 16777216, 10, 3);

            Console.Write("Доступные символы: ");
            foreach (var sym in smartphone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {smartphone.PhoneNumber}");
            Console.WriteLine($"Ширина экрана (пиксели): {smartphone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {smartphone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {smartphone.ScreenSize}");
            Console.WriteLine($"Цвет телефона: {smartphone.PhoneColor}");
            Console.WriteLine($"Количество сим-карт: {(smartphone.TwoSIM ? 2 : 1)}");
            Console.WriteLine($"Второй номер: {(smartphone.TwoSIM ? smartphone.SecondaryPhoneNumber : "-")}");
            Console.WriteLine($"Сенсорный экран: {(smartphone.IsTouchScreen ? "да" : "нет")}");
            Console.WriteLine($"Максимальное количество касаний: {smartphone.MaxTouches}");
            Console.WriteLine($"Количество камер: {smartphone.CamerasQuantity}");
            smartphone.Call();
            smartphone.TakeCall("101");
            smartphone.SendSMS();
            smartphone.TakeSMS("101");
            smartphone.SendMMS();
            smartphone.TakeMMS("101");
            smartphone.TakePhoto();
            smartphone.RecordVideo();

            Console.ReadLine();
        }
    }
}
