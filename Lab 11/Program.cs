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
    }
}
