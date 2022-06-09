using System;

namespace BARS.Internship.Task4.Figure
{
    public class Triangle : Figure
    {
        public double Height { get; set; }
        
        public Triangle(double length, double height) : base(length)
        {
            Height = height;
        }

        public override double area()
        {
            Area = 0.5 * Height * Length;
            return Area;
        }

        public override double perimeter()
        {
            // ?
            return 0;
        }

        public override void InfoFigure()
        {
            Console.WriteLine($"Фигура: треугольник\nВысота: {Height}");
            base.InfoFigure();
        }
    }
}