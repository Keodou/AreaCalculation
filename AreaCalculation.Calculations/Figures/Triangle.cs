namespace AreaCalculation.Calculations.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c) 
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double CalculateArea()
        {
            double halfMeter = (_a + _b + _c) / 2;
            return Math.Sqrt(halfMeter * (halfMeter - _a) * (halfMeter - _b) * (halfMeter - _c));
        }

        /// <summary>
        /// Is the triangle rectangular or not.
        /// </summary>
        /// <returns></returns>
        public bool IsTriangleRectangular()
        {
            if (_a * _a + _b * _b == _c * _c ||
            _a * _a + _c * _c == _b * _b ||
            _b * _b + _c * _c == _a * _a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
