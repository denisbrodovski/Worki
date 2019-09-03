﻿using System;
using Xunit;

namespace Shape
{
    public class ShapeTests
    {
        [Theory]
        [InlineData(-100, 0, typeof(ArgumentException))]
        [InlineData(0, 0, typeof(ArgumentException))]
        [InlineData(10, 314, null)]
        public void TestCircle(double R, double area, Type exceptionType)
        {
            try
            {
                Circle circle = new Circle(R);
                double result = circle.Area();
                Assert.True(exceptionType == null, $"Area method is expected to throw {exceptionType}");
                Assert.Equal(area, Math.Floor(result));
            }
            catch (Exception e)
            {
                Assert.Equal(exceptionType, e.GetType());
            }
        }

        [Theory]
        [InlineData(1, 2, 3, 200, typeof(ArgumentException))]
        public void TestTriangle(double a, double b, double c, double area, Type exceptionType)
        {
            try
            {
                Triangle triangle = new Triangle(a, b, c);
                double result = triangle.Area();
                Assert.True(exceptionType == null, $"Area method is expected to throw {exceptionType}");
                Assert.Equal(area, result);
            }
            catch (Exception e)
            {
                Assert.Equal(exceptionType, e.GetType());
            }
        }
    }
}
