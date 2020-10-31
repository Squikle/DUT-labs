using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Введите количество ваших чисел: ");
            int amount;
            while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.Write("Некорректный ввод. Допускаются только значения больше 0. Попробуйте снова: ");
            }

            List<int> list = new List<int>(amount);

            for (int i=0; i<list.Capacity; i++)
            {
                Console.Write($"Введите {i+1} число: ");
                int input;
                while (!int.TryParse(Console.ReadLine(), out input) || !IsPrimeNumber(input))
                {
                    Console.Write("Некорректный ввод. Допускаются только простые числа. Попробуйте снова: ");
                }
                list.Add(input);
            }

            Console.WriteLine($"\nПовторения чисел:");
            HashSet<int> checkedNumbers = new HashSet<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                int count = 0;
                if (!checkedNumbers.Contains(list[i]))
                    checkedNumbers.Add(list[i]);
                else 
                    continue;

                for (int j = i+1; j < list.Count(); j++)
                {
                    if (list[j] == list[i])
                        count++;
                }
                Console.WriteLine($"{list[i]} повторяется {count} раз");
            }

            int[] array = list.ToArray(); // Копирование в массив

            Console.ReadLine();
            return 0;
        }

        public static bool IsPrimeNumber(int number)
        {
            var result = true;

            if (number > 1)
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            else
                result = false;

            return result;
        }
    }
}
