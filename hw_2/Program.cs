using System;
using System.Linq;


namespace myApp
{
    abstract class Shape
    {
        public abstract bool isValid();
        public abstract float getArea();
    }

    class Rectangle : Shape
    {
        public float side_a, side_b;

        public Rectangle(float a, float b)
        {
            side_a = a;
            side_b = b;
        }
        public override bool isValid()
        {
            return (side_a > 0) && (side_b > 0);
        }
        public override float getArea()
        {
            return side_a * side_b;
        }
    }

    class Circle : Shape
    {
        public float radius;

        public Circle(float r)
        {
            radius = r;
        }
        public override bool isValid()
        {
            return radius > 0;
        }
        public override float getArea()
        {
            return radius * radius * 3.14159f;
        }
    }

    class Square : Rectangle
    {
        public Square(float a) : base(a, a) { }
        public override bool isValid()
        {
            return base.isValid() && (side_a == side_b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Square(1.25f),
                new Rectangle(22f, 6f),
                new Circle(5.5f),
                new Rectangle(2f, 1f),
                new Square(6.25f),
                new Rectangle(4f, 3.1f),
                new Square(3f),
                new Circle(2f),
                new Square(10f),
                new Rectangle(4f, 3f)
            };

            float totalArea = shapes.Sum(s => s.getArea());
            Console.WriteLine($"总面积为 : {totalArea}");
        }
    }
}
