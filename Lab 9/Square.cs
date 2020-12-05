using System;

namespace Lab_9
{
    class Square : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertices => 4;
        public override string ShapeName { get; }
        public int SideLenght { get; set; }

        public Square(string shapeName)
        {
            Random rand = new Random();
            ShapeName = shapeName;
            Color = (ConsoleColor)rand.Next(16);
            SideLenght = rand.Next(1,11);
        }
        public Square(string shapeName, int size)
        {
            ShapeName = shapeName;
            Color = (ConsoleColor)new Random().Next(16);
            SideLenght = size;
        }
        public Square(string shapeName, int size, int color)
        {
            ShapeName = shapeName;
            Color = (ConsoleColor)color;
            SideLenght = size;
        }

        public override double GetSquare() => SideLenght * SideLenght; 
        public override double GetPerimeter() => SideLenght * 4;
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Фигура: Квадрат;" +
                              $"\nНазвание фигуры: {ShapeName};" +
                              $"\nКоличество вершин: {NumberVertices};" +
                              $"\nДлинна стороны: {SideLenght};" +
                              $"\nПлощадь: {GetSquare()};" +
                              $"\nПериметр: {GetPerimeter()}.");
            Console.ResetColor();
        }
    }
}
