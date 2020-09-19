using System;
using System.Globalization;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            int start;
            int finish;

            Console.WriteLine("Введите стартовый элемент (целое число): ");
            string start_index_str = Console.ReadLine();
            finish = Convert.ToInt32(start_index_str);

            Console.WriteLine("Введите финишный элемент (целое число): ");
            string finish_index_str = Console.ReadLine();
            start = Convert.ToInt32(finish_index_str);

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
            {
                Console.WriteLine("Ошибка. Некорректные числа");
            }

            Console.ReadKey();
        }
    }
}