namespace AreaCalculation.Calculations.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
