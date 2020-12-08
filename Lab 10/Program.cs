using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int task1 = 123;
            Console.WriteLine("task 1:\t\t" + task1.Reverse());

            // Task 2
            string task2 = "test";
            Console.WriteLine("task 2:\t\t" + task2.Reverse());

            // Task 3
            double task3 = 12.321;
            Console.WriteLine("task 3:\t\t" + Convert.ToDouble(task3.SplitReverse()));

            // Task 4
            string task4 = "sa,ffdd,afdss,qgasfg,54";
            Console.WriteLine("task 4:\t\t" + task4.SplitReverse());

            // Task 7
            Console.Write("task 7:\t\t");
            int[] task7 = new int[10] { 1, 3, 5, 1, 6, 3, 2, 1, 6, 10 };
            var reversedArray = task7.Reverse();
            for (int i = 0; i < reversedArray.Length; i++)
                Console.Write(" " + reversedArray[i]);
            Console.WriteLine();

            // Variant 7 Task
            int[] variantTask = {1, 3, 2, 4, 5, 6};
            Console.Write("variant 7 task:\t\t ");
            variantTask.PrintArrayEvenOdd();

            Console.ReadKey();
        }
    }
}
