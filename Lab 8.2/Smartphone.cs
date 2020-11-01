using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class Smartphone : ColorPhone
    {
        public bool IsTouchScreen { get; set; }
        public int MaxTouches { get; set; }
        public int CamerasQuantity { get; set; }

        public Smartphone(string phoneNumber, int screenWidth, int screenHeight,
            double screenSize, string phoneColor,
            int screenColorsQuantity,
            int maxTouches, int camerasQuantity,
            string secondaryPhoneNumber = null)
            : base(phoneNumber, screenWidth, screenHeight, screenSize, phoneColor, screenColorsQuantity, secondaryPhoneNumber)
        {
            MaxTouches = maxTouches;
            CamerasQuantity = camerasQuantity;
            if (MaxTouches > 0)
                IsTouchScreen = true;
        }
        public void TakePhoto()
        {
            if (CamerasQuantity == 1)
                Console.WriteLine($"Сделано фото с камеры 1");
            else if (CamerasQuantity > 1)
            {
                Console.Write($"Выберите с какой камеры хотите сделать фото (у вас {CamerasQuantity} камер): ");
                int choosenCamera;
                while (!int.TryParse(Console.ReadLine(), out choosenCamera) || choosenCamera < 1 || choosenCamera > CamerasQuantity)
                    Console.WriteLine("Некорректный ввод. Введите значение в диапазоне количества камер смартфона: ");

                Console.WriteLine($"Сделано фото с камеры {choosenCamera}");
            }
            else
                Console.WriteLine("У смартфона нет камер");
        }

        public void RecordVideo()
        {
            if (CamerasQuantity == 1)
                Console.WriteLine($"Снято видео на камеру 1");
            else if (CamerasQuantity > 1)
            {
                Console.Write($"Выберите с какой камеры хотите записать видео (у вас {CamerasQuantity} камер): ");
                int choosenCamera;
                while (!int.TryParse(Console.ReadLine(), out choosenCamera) || choosenCamera < 1 || choosenCamera > CamerasQuantity)
                    Console.WriteLine("Некорректный ввод. Введите значение в диапазоне количества камер смартфона: ");

                Console.WriteLine($"Снято видео на камеру {choosenCamera}");
            }
            else
                Console.WriteLine("У смартфона нет камер");
        }
    }
}
