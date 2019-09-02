using System;
using Xunit;

namespace Shape
{
    public class ShapeTests
    {
        [Theory]
        [InlineData(-100, 0, typeof(ArgumentException))]
        [InlineData(0, 0, typeof(ArgumentException))]
        [InlineData(1.34, 100, null)]
        [InlineData(57.334, 100, null)]
        public void TestCircle(double R, double area, Type exceptionType)
        {
            try
            {
                var circle = new Circle(R);
                double result = circle.Area();
                Assert.True(exceptionType == null, $"Area method is expected to throw {exceptionType}");
                Assert.Equal(area, result);
            }
            catch (Exception e)
            {
                Assert.Equal(exceptionType, e.GetType());
            }
        }

        [Theory]
        [InlineData(1, 2, 3, 200, null)]
        public void TestTriangle(double a, double b, double c, double area, Type exceptionType)
        {
            try
            {
                var circle = new Triangle(a, b, c);
                double result = circle.Area();
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
