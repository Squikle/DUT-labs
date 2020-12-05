using System;

namespace Lab_9
{
    class Square : Shape
    {
        public override string Color { get; set; }
        public override int NumberVertices => 4;
        public override string ShapeName { get; }
        public int SideLenght { get; set; }

        public Square(string shapeName)
        {
            Random rand = new Random();
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", rand.Next(0x1000000));
            SideLenght = rand.Next(1,11);
        }
        public Square(string shapeName, int size)
        {
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", new Random().Next(0x1000000));
            SideLenght = size;
        }
        public Square(string shapeName, int size, string сolor)
        {
            ShapeName = shapeName;
            Color = сolor;
            SideLenght = size;
        }

        public override double GetSquare() => SideLenght * 4;
        public override double GetPerimeter() => SideLenght * SideLenght;
    }
}
