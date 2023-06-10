using AreaCalculation.Calculations.Figures;

namespace AreaCalculation.Tests
{
    public class CircleTest
    {
        [Fact]
        public void ShouldCalculateCircleArea()
        {
            double radius = 10;
            double expectedArea = Math.PI * radius * radius;
            Circle circle = new(radius);
            double actualArea = circle.CalculateArea();
            Assert.Equal(expectedArea, actualArea);
        }
    }
}