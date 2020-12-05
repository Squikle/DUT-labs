using System;

namespace Lab_9
{
    class Triangle : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertices => 3;
        public override string ShapeName { get; }
        public int LateralSideLenght { get; set; }
        public int BaseSideLenght { get; set; }

        public Triangle(string shapeName)
        {
            Random rand = new Random();
            ShapeName = shapeName;
            Color = (ConsoleColor)rand.Next(16);
            LateralSideLenght = rand.Next(100);
            BaseSideLenght = rand.Next(LateralSideLenght * 2);
        }

        public Triangle(string shapeName, int lateralSideLenght, int baseSideLenght)
        {
            ShapeName = shapeName;
            Color = (ConsoleColor)new Random().Next(16);
            LateralSideLenght = lateralSideLenght;
            BaseSideLenght = baseSideLenght;
        }
        public Triangle(string shapeName, int lateralSideLenght, int baseSideLenght, int color)
        {
            ShapeName = shapeName;
            Color = (ConsoleColor)color;
            LateralSideLenght = lateralSideLenght;
            BaseSideLenght = baseSideLenght;
        }

        public override double GetSquare() => 0.5 * BaseSideLenght * Math.Sqrt(4 * LateralSideLenght ^ 2 - BaseSideLenght ^ 2);

        public override double GetPerimeter() => BaseSideLenght + LateralSideLenght * LateralSideLenght;

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Фигура: Равнобедренный треугольник;" +
                              $"\nНазвание фигуры: {ShapeName};" +
                              $"\nКоличество вершин: {NumberVertices};" +
                              $"\nДлина основы: {BaseSideLenght};" +
                              $"\nДлина боковых сторон: {LateralSideLenght};" +
                              $"\nПлощадь: {GetSquare()};" +
                              $"\nПериметр: {GetPerimeter()}.");
            Console.ResetColor();
        }
    }
}
