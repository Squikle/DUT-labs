using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_81
{
    class Program
    {
        static int Main(string[] args)
        {
            Garage garage = new Garage();

            while (true)
            {
                Console.WriteLine(
                    "Выберите операцию:\n" +
                    "1. Добавить машину в гараж\n" +
                    "2. Убрать машину из гаража\n" +
                    "3. Взять машину\n" +
                    "4. Посмотреть все машины\n" +
                    "0. Выйти из гаража"
                    );
                int operation;
                while (!int.TryParse(Console.ReadLine(), out operation) || operation < 0 || operation > 4)
                {
                    Console.Write("Некорректный ввод. Попробуйте снова: ");
                }
                // Выход из гаража
                if (operation == 0)
                    return 0;
                // Вывод машин в гараже
                else if (operation == 1)
                {
                    string name;
                    string color;
                    int speed;
                    int year;

                    Console.WriteLine("Выбор машины: ");
                    Console.Write("Введите название машины: ");
                    while (true)
                    {
                        name = Console.ReadLine();
                        if (string.IsNullOrEmpty(name))
                            Console.Write("Некорректный ввод. Попробуйте снова: ");
                        else break;
                    }

                    Console.Write("Введите цвет машины: ");
                    while (true)
                    {
                        color = Console.ReadLine();
                        if (string.IsNullOrEmpty(color))
                            Console.Write("Некорректный ввод. Попробуйте снова: ");
                        else break;
                    }

                    Console.Write("Введите скорость машины: ");
                    while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
                        Console.Write("Некорректный ввод. Скорость не может быть равна или меньше 0. Попробуйте снова: ");

                    Console.Write("Введите год выпуска машины: ");
                    while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
                        Console.Write("Некорректный ввод. Год выпуска не может быть равен или меньшим 0. Попробуйте снова: ");

                    // Добавление
                    Car operatingCar = new Car(name, color, speed, year);
                    garage.AddCar(operatingCar);
                    Console.WriteLine("Машина успешно добавлена.");
                }
                else if (operation == 4)
                {
                    Console.WriteLine(garage);
                }
                else
                {
                    string name;
                    string color;
                    int speed;
                    int year;

                    Console.WriteLine("Выбор машины (чтобы оставить поле пустым введите \"0\"): ");
                    Console.Write("Введите название машины: ");
                    name = Console.ReadLine();

                    Console.Write("Введите цвет машины: ");
                    color = Console.ReadLine();

                    Console.Write("Введите скорость машины: ");
                    while (!int.TryParse(Console.ReadLine(), out speed) || speed < 0)
                        Console.Write("Некорректный ввод. Попробуйте снова: ");

                    Console.Write("Введите год выпуска машины: ");
                    while (!int.TryParse(Console.ReadLine(), out year) || year < 0)
                        Console.Write("Некорректный ввод. Попробуйте снова: ");

                    var candidates = garage.GetCars(new Car(name, color, speed, year));
                    if (candidates.Count() < 1)
                    {
                        Console.WriteLine("В гараже нет такой машины. \n");
                        continue;
                    }
                    Console.WriteLine("Подходящие под критерии поиска машины: ");
                    for (int i = 0; i < candidates.Count(); i++)
                        Console.WriteLine($"Машина #{i + 1}:\n{candidates.ElementAt(i)}");

                    // Удаление машины
                    if (operation == 2)
                    {
                        if (candidates.Count() > 1)
                        {
                            Console.WriteLine("Выберите машину по номеру: ");
                            int choosenNumber;
                            while (!int.TryParse(Console.ReadLine(), out choosenNumber) || choosenNumber <= 0 || choosenNumber > candidates.Count())
                            {
                                Console.Write("Некорректный ввод. Попробуйте снова: ");
                            }
                            garage.RemoveCar(candidates.ElementAt(choosenNumber - 1));
                        }
                        else
                            garage.RemoveCar(candidates.ElementAt(0));

                        Console.WriteLine($"Машина убрана из гаража.");
                    }
                    // Выбор машины покататься
                    else if (operation == 3)
                    {
                        if (candidates.Count() > 1)
                        {
                            Console.WriteLine("Выберите машину по номеру: ");
                            int choosenNumber;
                            while (!int.TryParse(Console.ReadLine(), out choosenNumber) || choosenNumber <= 0 || choosenNumber > candidates.Count())
                            {
                                Console.Write("Некорректный ввод. Попробуйте снова: ");
                            }
                            candidates.ElementAt(choosenNumber - 1).RideCar();
                        }
                        else
                            candidates.ElementAt(0).RideCar();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
