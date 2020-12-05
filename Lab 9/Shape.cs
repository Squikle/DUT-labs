namespace Lab_9
{
    abstract class Shape
    {
        public abstract string Color { get; set; }
        public abstract int NumberVertices { get; }
        public abstract string ShapeName { get; }
        public abstract double GetSquare();
        public abstract double GetPerimeter();
    }
}
