using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5 // 7. Дана матриця розміру m * n. Знайти 1) мінімальний; 2) максимальний серед 1) максимальних; 2) мінімальних елементів кожного рядка(стовпчика).
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Примечание: матрица состоит из целых чисел");
            Console.Write("Введите количество рядов матрицы: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбиков матрицы: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            if (rows <= 0 || cols <= 0)
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadKey();
                return;
            }

            int[,] array = new int[rows, cols];

            for (int i = 0; i < array.GetLength(0); i++) // ввод массива
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Введите элемент матрицы ({i+1},{j+1}): ");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            for (int i = 0; i < array.GetLength(0); i++) // вывод массива
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            // пошук мінімального елементу (1)
            int min = array[0, 0]; 
            foreach (var i in array)
                if (i < min)
                    min = i;
            Console.WriteLine("Минимальный элемент: {0}", min);

            // пошук максимального елементу серед максимальних елементів кожного рядку (просто максимальний елемент масиву) (2.1)
            int max = array[0, 0]; 
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i,j] > max)
                        max = array[i,j];

            Console.WriteLine("Максимальный элемент среди максимальных элементов каждой строки: {0}", max);

            // пошук максимального елементу серед мінімальних елементів кожного рядку (2.2)
            int maxAmongMin = min;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int minInRow = array[i, 0];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minInRow)
                        minInRow = array[i, j];
                }
                if (minInRow > maxAmongMin)
                    maxAmongMin = minInRow;
            }

            Console.WriteLine("Максимальный элемент среди минимальных элементов каждой строки: {0}", maxAmongMin);

            Console.ReadKey();
        }
    }
}
