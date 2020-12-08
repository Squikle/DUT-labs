using System;

namespace Lab_11
{
    class Program
    {
        static void Main()
        {
            CarService carService = new CarService();

            Console.WriteLine("\tCar1 full service requested:\n");
            Car car1 = new Car();
            Console.WriteLine(car1);
            Console.WriteLine();
            DoFullService(carService).Invoke(car1);
            Console.WriteLine(car1);
            Console.WriteLine();

            Console.WriteLine("\tCar2 prevention service requested:\n");
            Car car2 = new Car();
            Console.WriteLine(car2);
            Console.WriteLine();
            DoPreventionService(carService).Invoke(car2);
            Console.WriteLine(car2);
            Console.WriteLine();

            Console.WriteLine("\tCar3 wheel service requested:\n");
            Car car3 = new Car();
            Console.WriteLine(car3);
            Console.WriteLine();
            DoWheelService(carService).Invoke(car3);
            Console.WriteLine(car3);
            Console.WriteLine();

            Console.WriteLine("\tCar4 own service request:\n");
            Car car4 = new Car();
            Console.WriteLine(car4);
            Console.WriteLine();
            CarService.ServiceDelegate operation = RequestCustomService(carService);
            if (operation != null)
            {
                operation.Invoke(car4);
                Console.WriteLine(car4);
            }
            else
                Console.WriteLine("Работы не были проведены");

            Console.ReadKey();
        }

        static CarService.ServiceDelegate DoFullService(CarService carService)
        {
            CarService.ServiceDelegate serviceOperation = null;
            serviceOperation += carService.ChangeOil;
            serviceOperation += carService.FullInspect;
            serviceOperation += carService.Paint;
            serviceOperation += carService.RepairBody;
            serviceOperation += carService.ReplaceWheels;
            serviceOperation += carService.TuneWheelAlignment;
            return serviceOperation;
        }
        static CarService.ServiceDelegate DoPreventionService(CarService carService)
        {
            CarService.ServiceDelegate serviceOperation = null;
            serviceOperation += carService.ChangeOil;
            serviceOperation += carService.FullInspect;
            return serviceOperation;
        }
        static CarService.ServiceDelegate DoWheelService(CarService carService)
        {
            CarService.ServiceDelegate serviceOperation = null;
            serviceOperation += carService.ChangeOil;
            serviceOperation += carService.ReplaceWheels;
            serviceOperation += carService.TuneWheelAlignment;
            return serviceOperation;
        }
        static CarService.ServiceDelegate RequestCustomService(CarService carService)
        {
            CarService.ServiceDelegate serviceOperation = null;
            ConsoleKey response;
            while (true)
            {
                Console.Write("Хотите сделать развал-схождение? [y/n]");
                response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                    serviceOperation += carService.TuneWheelAlignment;
                else if (response != ConsoleKey.N)
                    continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите поменять масло? [y/n]");
                response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                    serviceOperation += carService.ChangeOil;
                else if (response != ConsoleKey.N)
                    continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите сделать покраску? [y/n]");
                response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                    serviceOperation += carService.Paint;
                else if (response != ConsoleKey.N)
                    continue;

                Console.WriteLine();
                break;
            }
            while(true)
            {
                Console.Write("Хотите сделать полный техосмотр?");
                response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                    serviceOperation += carService.FullInspect;
                else if (response != ConsoleKey.N)
                    continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите заменить колеса?");
                response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                    serviceOperation += carService.ReplaceWheels;
                else if (response != ConsoleKey.N)
                    continue;

                Console.WriteLine();
                break;
            }
            while(true)
            {
                Console.Write("Хотите починить кузов?");
                response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                    serviceOperation += carService.RepairBody;
                else if (response != ConsoleKey.N)
                    continue;

                Console.WriteLine();
                break;
            }

            return serviceOperation;
        }
    }
}
