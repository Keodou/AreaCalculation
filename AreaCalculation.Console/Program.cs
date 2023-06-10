using AreaCalculation.Calculations;
using AreaCalculation.Calculations.Figures;

IFigure figure = new Circle(10);
double areaCircle = figure.CalculateArea();
Console.WriteLine($"Area of the circle is {areaCircle}");

IFigure figure2 = new Triangle(3, 4, 5);
double areaTriangle = figure2.CalculateArea();
Console.WriteLine($"Area of the triangle is {areaTriangle}");