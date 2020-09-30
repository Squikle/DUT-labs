using System;

namespace Lab_3 //7. Перевірити істинність вислову: Серед трьох даних цілих чисел є хоч би одна пара співпадаючих
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a == b || b == c || a == c));
            Console.ReadKey();
        }
    }
}
