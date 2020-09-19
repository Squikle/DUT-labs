using System;
using System.Globalization;

namespace Lab_2 // Варіант 7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стартовый элемент (целое число): ");
            int finish = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите финишный элемент (целое число): ");
            int start = Convert.ToInt32(Console.ReadLine());

            double summ = 0;
            if (finish <= start && finish >= 0)
            {
                for (int i = finish; i < start; i++)
                {
                    double currentI = (Math.Pow(i, 2) + Math.Pow(-1, i - 1) * 2 * i - 1) / (Math.Pow(i, 2) + 8);
                    summ += currentI;
                    Console.WriteLine(currentI);
                }
                Console.WriteLine("Сумма ряда: {0}", summ); ;
            }
            else
                Console.WriteLine("Ошибка. Некорректные числа");

            Console.ReadKey();
        }
    }
}