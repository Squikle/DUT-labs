using System;
using System.Collections.Generic;
using System.Linq;

namespace Independent_work_1
{
    class Program
    {
        static void Main()
        {
            Planshets planshets = new Planshets();
            Console.WriteLine(planshets);

            string brand;
            int year;
            int price;
            string color;

            while (true)
            {
                Console.WriteLine("Выбор планшета (чтобы оставить поле пустым введите \"0\"): ");
                Console.Write("Введите бренд планшета: ");
                brand = Console.ReadLine();

                Console.Write("Введите год выпуска планшета: ");
                while (!int.TryParse(Console.ReadLine(), out year) || year < 0)
                    Console.Write("Некорректный ввод. Попробуйте снова: ");

                Console.Write("Введите цвет планшета: ");
                color = Console.ReadLine();

                Console.Write("Введите цену планшета: ");
                while (!int.TryParse(Console.ReadLine(), out price) || price < 0)
                    Console.Write("Некорректный ввод. Попробуйте снова: ");

                List<Planshet> candidates = planshets.GetPlanshets(new Planshet(brand, year, price, new List<string> { color })).ToList();
                if (!candidates.Any())
                {
                    Console.WriteLine("Такого планшета нет в наличии. \n");
                    continue;
                }
                Console.WriteLine("Подходящие под критерии поиска планшеты: ");
                for (int i = 0; i < candidates.Count(); i++)
                    Console.WriteLine($"Планшет #{i + 1}:\n{candidates.ElementAt(i)}");
            }
        }
    }
}
