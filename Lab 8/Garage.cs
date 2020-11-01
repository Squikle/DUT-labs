using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_81
{
    class Garage
    {
        private List<Car> Cars { get; set; }

        public Garage()
        {
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
            => Cars.Add(car);

        public void RemoveCar(Car car)
        {
            foreach (var _car in Cars.ToArray())
                if (car == _car)
                {
                    Cars.Remove(_car);
                    return;
                }
        }

        public IEnumerable<Car> GetCars(Car car)
        {
            LinkedList<Car> candidates = new LinkedList<Car>();
            foreach (var _car in Cars)
            {
                if (car.Name != "0" && _car.Name != car.Name)
                    continue;
                else if (car.Color != "0" && _car.Color != car.Color)
                    continue;
                else if (car.Speed != 0 && _car.Speed != car.Speed)
                    continue;
                else if (car.Year != 0 && _car.Year != car.Year)
                    continue;

                candidates.AddFirst(_car);
            }
            return candidates;
        }

        public override string ToString()
        {
            if (Cars.Count() <= 0)
                return "Гараж пуст.";
            StringBuilder cars = new StringBuilder();
            for (int i = 0; i < Cars.Count(); i++)
            {
                cars.Append($"Машина #{i + 1}:\n{Cars[i]}");
            }
            return cars.ToString();
        }
    }
}
