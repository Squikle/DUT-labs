using System.Collections.Generic;
using System.Text;

namespace Independent_work_1
{
    class Planshet
    {
        public string Brand;
        public int Year;
        public int Price;
        public readonly List<string> Colors;

        public Planshet(string brand, int year, int price, List<string> colors)
        {
            Colors = colors;
            Year = year;
            Price = price;
            Brand = brand;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder($"\tПланшет от бренда: {Brand}\n" +
                                                   $"\tГод выпуска: {Year}\n" +
                                                   "\tЦвета: ");
            foreach (var color in Colors)
                info.Append(color + " ");
            info.Append($"\n\tЦена: {Price}");
            return info.ToString();
        }
    }
}
