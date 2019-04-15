using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[3];
            shapes[0] = new Square();
            shapes[1] = new Triangle();
            shapes[2] = new Circle();
            foreach(var shape in shapes)
            {
                shape.CalculateArea();
            }

            Console.Read();
        }
    }

    class Shape
    {
        public virtual void CalculateArea()
        {
        }
    }

    class Square : Shape
    {
        private double _side;

        public Square()
        {
            Console.WriteLine("Enter the side of the square:");
            _side = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"This is a square. CLR type is {this.GetType()}. The area is {_side * _side}");
        }
    }

    class Triangle : Shape
    {
        private double _base;
        private double _height;

        public Triangle()
        {
            Console.WriteLine("Enter the base of the triangle:");
            _base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle:");
            _height = Convert.ToDouble(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"This is a triangle. CLR type is {this.GetType()}. The area is {(_base / 2) * _height}");
        }
    }

    class Circle : Shape
    {
        private const double Pi = 3.14;
        private double _radius;

        public Circle()
        {
            Console.WriteLine("Enter the radius of the circle:");
            _radius = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"This is a circle. CLR type is {this.GetType()}. The area is {_radius * _radius * Pi}");
        }
    }
}
