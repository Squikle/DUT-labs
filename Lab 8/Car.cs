using System;

namespace Lab_81
{
    class Car
    {
        public string Name { get; }
        public string Color { get; }
        public int Speed { get; }
        public int Year { get; }

        public Car(string name, string color, int speed, int year)
        {
            Name = name;
            Color = color;
            Speed = speed;
            Year = year;
        }

        public void RideCar() 
            => Console.WriteLine($"Вы взяли покататься машину {Color} {Name} {Year}");

        public override string ToString()
            => $"\tНазвание: {Name}\n\tЦвет: {Color}\n\tСкорость: {Speed}\n\tГод выпуска: {Year}\n";
    }
}
