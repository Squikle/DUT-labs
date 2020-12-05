using System;

namespace Lab_9
{
    class Circle : Shape
    {
        public override string Color { get; set; }
        public override int NumberVertices { get; }
        public override string ShapeName { get; }
        public int Radius { get; set; }

        public Circle(string shapeName)
        {
            ShapeName = shapeName;
        }

        public Circle(string shapeName, int size)
        {
            ShapeName = shapeName;
            Radius = size;
        }
        
        public Circle(string shapeName, int size, string color)
        {
            ShapeName = shapeName;
            Radius = size;
            Color = color;
        }
        public override double GetPerimeter() => Math.PI * (Radius * Radius);
        public override double GetSquare() => 2 * Math.PI * Radius;
    }
}
