using System;

namespace Shape
{
    public class Triangle : IShape
    {
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Edge lengths should be positive");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Edge lengths should satisfy triangle inequality");

            A = a;
            B = b;
            C = c;
        }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Area()
        {
            double halfPerimeter = (A + B + C) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            return area;
        }
    }
}
