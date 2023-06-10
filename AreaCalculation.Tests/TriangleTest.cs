using AreaCalculation.Calculations.Figures;

namespace AreaCalculation.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void ShouldCalculateTriangleArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = 6;
            Triangle triangle = new(a, b, c);
            double actualArea = triangle.CalculateArea();
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void ShouldTriangleIsRectangular()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new(a, b, c);
            bool actualResult = triangle.IsTriangleRectangular();
            Assert.True(actualResult);
        }
        
        [Fact]
        public void ShouldTriangleIsNotRectangular()
        {
            double a = 3;
            double b = 4;
            double c = 4;
            Triangle triangle = new(a, b, c);
            bool actualResult = triangle.IsTriangleRectangular();
            Assert.False(actualResult);
        }
    }
}
