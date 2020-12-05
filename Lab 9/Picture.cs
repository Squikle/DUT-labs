using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Picture : IDraw
    {
        private List<Shape> _shapes;
        public int ShapeCount => _shapes.Count;

        public Picture()
        {
            _shapes = new List<Shape>();
        }

        public Picture(int shapesNumber)
        {
            _shapes = new List<Shape>(shapesNumber);
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }
        public bool RemoveShape(string name, string type, double square)
        {
            if (type.Equals("Square", StringComparison.CurrentCultureIgnoreCase))
            {
                _shapes.RemoveAll(s => s is Square && s.ShapeName == name && s.GetSquare() > square);
                return true;
            }
            if (type.Equals("Circle", StringComparison.CurrentCultureIgnoreCase))
            {
                _shapes.RemoveAll(s => s is Circle && s.ShapeName == name && s.GetSquare() > square);
                return true;
            }
            if (type.Equals("Triangle", StringComparison.CurrentCultureIgnoreCase))
            {
                _shapes.RemoveAll(s => s is Triangle && s.ShapeName == name && s.GetSquare() > square);
                return true;
            }
            return false;
        }
        public Shape this[int index] => _shapes.ElementAtOrDefault(index);

        public void Draw()
        {
            foreach (var shape in _shapes)
                shape.Draw();
        }
    }
}
