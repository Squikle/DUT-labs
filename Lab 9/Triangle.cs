using System;

namespace Lab_9
{
    class Triangle : Shape
    {
        public override string Color { get; set; }
        public override int NumberVertices { get; }
        public override string ShapeName { get; }
        public int LateralSideLenght { get; set; }
        public int BaseSideLenght { get; set; }

        public Triangle(string shapeName)
        {
            Random random = new Random();
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", random.Next(0x1000000));
            LateralSideLenght = random.Next(100);
            BaseSideLenght = random.Next(LateralSideLenght * 2);
        }

        public Triangle(string shapeName, int lateralSideLenght, int baseSideLenght)
        {
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", new Random().Next(0x1000000));
            LateralSideLenght = lateralSideLenght;
            BaseSideLenght = baseSideLenght;
        }
        public Triangle(string shapeName, int lateralSideLenght, int baseSideLenght, string color)
        {
            ShapeName = shapeName;
            Color = color;
            LateralSideLenght = lateralSideLenght;
            BaseSideLenght = baseSideLenght;
        }

        public override double GetSquare() => BaseSideLenght + LateralSideLenght * 2;

        public override double GetPerimeter() => 0.25 * BaseSideLenght * Math.Sqrt(4 * LateralSideLenght ^ 2 - BaseSideLenght ^ 2);
    }
}
