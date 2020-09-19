using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту конуса: ");
            double height = Double.Parse(Console.ReadLine());

            Console.Write("Введите радиус конуса: ");
            double radius = Double.Parse(Console.ReadLine());

            Console.WriteLine((Math.PI*Math.Pow(radius, 2)*height)/3);
            Console.ReadKey();
        }
    }
}
