using System;
using Xunit;

namespace Shape
{
    public class ShapeTests
    {   // поскольку площади фигур в большинстве дробные, то в тесте проверяем с точностью до сотых
        [Theory]
        [InlineData(-100, 0, typeof(ArgumentException))]
        [InlineData(0, 0, typeof(ArgumentException))]
        [InlineData(10, 314.16, null)]
        public void TestCircle(double R, double area, Type exceptionType)
        {
            try
            {
                Circle circle = new Circle(R);
                double result = circle.Area();
                Assert.True(exceptionType == null, $"Area method is expected to throw {exceptionType}");
                Assert.Equal(area, Math.Round(result, 2));
            }
            catch (Exception e)
            {
                Assert.Equal(exceptionType, e.GetType());
            }
        }

        [Theory]
        [InlineData(1, 2, 3, 200, typeof(ArgumentException))]
        [InlineData(6, 7, 9, 20.98, null)]
        public void TestTriangle(double a, double b, double c, double area, Type exceptionType)
        {
            try
            {
                Triangle triangle = new Triangle(a, b, c);
                double result = triangle.Area();
                Assert.True(exceptionType == null, $"Area method is expected to throw {exceptionType}");
                Assert.Equal(area, Math.Round(result, 2));
            }
            catch (Exception e)
            {
                Assert.Equal(exceptionType, e.GetType());
            }
        }
    }
}
