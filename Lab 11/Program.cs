using System;

namespace Lab_11
{
    class Program
    {
        public delegate void ServiceDelegate(Car carToService);
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

        static ServiceDelegate DoFullService(CarService carService)
        {
            ServiceDelegate serviceOperation;
            serviceOperation = carService.ChangeOil;
            serviceOperation += carService.FullInspect;
            serviceOperation += carService.Paint;
            serviceOperation += carService.RepairBody;
            serviceOperation += carService.ReplaceWheels;
            serviceOperation += carService.TuneWheelAlignment;
            return serviceOperation;
        }
        static ServiceDelegate DoPreventionService(CarService carService)
        {
            ServiceDelegate serviceOperation;
            serviceOperation = carService.ChangeOil;
            serviceOperation += carService.FullInspect;
            return serviceOperation;
        }
        static ServiceDelegate DoWheelService(CarService carService)
        {
            ServiceDelegate serviceOperation;
            serviceOperation = carService.ChangeOil;
            serviceOperation += carService.ReplaceWheels;
            serviceOperation += carService.TuneWheelAlignment;
            return serviceOperation;
        }
    }
}
