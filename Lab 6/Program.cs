using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int task1 = 123;
            Console.WriteLine("task 1: " + Reverse(task1));

            // Task 2
            string task2 = "test";
            Console.WriteLine("task 2: " + Reverse(task2));

            // Task 3
            double task3 = 12.321;
            Console.WriteLine("task 3: " + Convert.ToDouble(SplitReverse(task3)));

            // Task 4
            string task4 = "sa,ffdd,afdss,qgasfg,54";
            Console.WriteLine("task 4: " + SplitReverse(task4));

            // Task 5

            // Task 6
            Console.WriteLine();
            Console.WriteLine("task 6.1: " + RecurseReverse(task1));
            Console.WriteLine("task 6.2: " + RecurseReverse(task2));
            Console.WriteLine("task 6.3: " + Convert.ToDouble(RecurseSplitReverse(task3)));
            Console.WriteLine("task 6.4: " + RecurseSplitReverse(task4));
            Console.WriteLine();


            // Task 7
            Console.Write("task 7:");
            int[] task7 = new int[10] { 1, 3, 5, 1, 6, 3, 2, 1, 6, 10 };
            var reversedArray = Reverse(task7);
            for (int i = 0; i < reversedArray.Length; i++)
                Console.Write(" " + reversedArray[i]);

            // Task 8 (ref)
            Console.Write("\ntask 8.1:");
            int[] task81 = new int[10] { 1, 3, 5, 1, 6, 3, 2, 1, 6, 10 };
            Reverse(ref task81);
            for (int i = 0; i < task81.Length; i++)
                Console.Write(" " + task81[i]);
            // Task 8 (out)
            Console.Write("\ntask 8.2:");
            int[] task82 = new int[10] { 1, 3, 5, 1, 6, 3, 2, 1, 6, 10 };
            int[] newTask82 = null;
            Reverse(task82, out newTask82);
            for (int i = 0; i < newTask82.Length; i++)
                Console.Write(" " + newTask82[i]);

            Console.ReadKey();
        }

        // Task 1
        static int Reverse(int value)
        {
            int reversed = 0;
            while (value > 0)
            {
                int remainded = value % 10;
                reversed = (reversed * 10) + remainded;
                value = value / 10;
            }
            return reversed;
        }

        // Task 2
        static string Reverse(string value)
        {
            string reversed = string.Empty;
            for (int i = value.Length - 1; i >= 0; i--)
                reversed += value[i];
            return reversed;
        }

        // Task 3
        static double SplitReverse(double value) => 
            Double.Parse(SplitReverse(value.ToString()));

        // Task 4
        static string SplitReverse(string value)
        {
            string reversed = string.Empty;
            var strings = value.Split(',');

            for (int i = 0; i < strings.Length - 1; i++)
                reversed += Reverse(strings[i]) + ',';

            reversed += Reverse(strings[strings.Length - 1]);

            return reversed;
        }

        // Task 6
        static int RecurseReverse(int value, int reversed=0)
        {
            if (value == 0)
                return reversed;

            int remainded = value % 10;
            reversed = (reversed * 10) + remainded;
            return RecurseReverse(value / 10, reversed);
        }
        static string RecurseReverse(string value)
        {
            if (value.Length <= 0)
                return value;
            
            return value[value.Length - 1] + RecurseReverse(value.Substring(0, value.Length - 1));
        }
        static double RecurseSplitReverse(double value) =>
            Double.Parse(RecurseSplitReverse(value.ToString()));
        static string RecurseSplitReverse(string value)
        {
            string reversed = string.Empty;
            var strings = value.Split(',');

            for (int i = 0; i < strings.Length - 1; i++)
                reversed += RecurseReverse(strings[i]) + ',';

            reversed += RecurseReverse(strings[strings.Length - 1]);

            return reversed;
        }

        // Task 7
        static T[] Reverse<T>(T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1;
                i < array.Length;
                i++, j--)
            {
                newArr[i] = array[j];
            }

            return newArr;
        }

        // Task 8
        static void Reverse<T>(ref T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1;
                i < array.Length;
                i++, j--)
            {
                newArr[i] = array[j];
            }

            array = newArr;
        }
        static void Reverse<T>(T[] array, out T[] newArray)
        {
            T[] tempArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1;
                i < array.Length;
                i++, j--)
            {
                tempArr[i] = array[j];
            }

            newArray = tempArr;
        }
    }
}
