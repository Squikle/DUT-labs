using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Globalization;

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
