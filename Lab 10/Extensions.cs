using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lab_10
{
    public static class Extensions
    {
       public static int Reverse(this int value)
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
       public static string Reverse(this string value)
        {
            string reversed = string.Empty;
            for (int i = value.Length - 1; i >= 0; i--)
                reversed += value[i];
            return reversed;
        }
       public static string SplitReverse(this string value)
        {
            string reversed = string.Empty;
            var strings = value.Split(',');

            for (int i = 0; i < strings.Length - 1; i++)
                reversed += Reverse(strings[i]) + ',';

            reversed += Reverse(strings[strings.Length - 1]);

            return reversed;
        }
       public static double SplitReverse(this double value) =>
            Double.Parse(SplitReverse(value.ToString(CultureInfo.CurrentCulture)));
       public static T[] Reverse<T>(this T[] array)
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
       public static void PrintArrayEvenOdd(this int[] array)
       {
           List<int> oddElements = array.Where(el => el % 2 == 0).ToList();
           oddElements.ForEach(el => Console.Write(el + " "));
           array.Except(oddElements).ToList().ForEach(el => Console.Write(el + " "));
       }
    }
}