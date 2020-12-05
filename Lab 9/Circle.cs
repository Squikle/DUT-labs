using System;

namespace Lab_9
{
    class Circle : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertices => 0;
        public override string ShapeName { get; }
        public int Radius { get; set; }

        public Circle(string shapeName)
        {
            Random random = new Random();
            Color = (ConsoleColor)random.Next(16);
            ShapeName = shapeName;
            Radius = random.Next(100);
        }

        public Circle(string shapeName, int size)
        {
            ShapeName = shapeName;
            Color = (ConsoleColor)new Random().Next(16);
            Radius = size;
        }
        
        public Circle(string shapeName, int size, int color)
        {
            ShapeName = shapeName;
            Radius = size;
            Color = (ConsoleColor)color;
        }
        public override double GetPerimeter() => Math.PI * (Radius * Radius);
        public override double GetSquare() => 2 * Math.PI * Radius;
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Фигура: Круг;" +
                              $"\nНазвание фигуры: {ShapeName};" +
                              $"\nКоличество вершин: {NumberVertices};" +
                              $"\nРадиус: {Radius};" +
                              $"\nПлощадь: {GetSquare()};" +
                              $"\nПериметр: {GetPerimeter()}.");
            Console.ResetColor();
        }
    }
}
