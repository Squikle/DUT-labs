using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4 // 7. Даний масив цілих чисел розміру N. Замінити всі додатні (від’ємні) елементи на значення мінімального(максимального) елементу.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество ваших чисел: ");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size <= 0)
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadKey();
                return;
            }
            int[] array = new int[size];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = array.Min();
            int max = array.Max();

            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0)
                    array[i] = min;
                else 
                    array[i] = max;

            Console.WriteLine("Ваша последовательность чисел: ");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            Console.ReadKey();
        }
    }
}
