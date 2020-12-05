using System;

namespace Lab_9
{
    abstract class Shape : IDraw
    {
        public abstract ConsoleColor Color { get; set; }
        public abstract int NumberVertices { get; }
        public abstract string ShapeName { get; }
        public abstract double GetSquare();
        public abstract double GetPerimeter();
        public abstract void Draw();
    }
}
