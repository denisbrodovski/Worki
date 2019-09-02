using System;

namespace Shape
{
    public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            pRadius = radius;
        }
        public double pRadius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius should be positive");
                }
                radius = value;
            }
        }
        public double Area()
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
