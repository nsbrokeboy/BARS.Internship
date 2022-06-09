using System;

namespace BARS.Internship.Task4.Figure
{
    public class Square : Figure
    {
        public Square(double length) : base(length)
        {
        }

        public override double area()
        {
            Area = Length * Length;
            return Area;
        }

        public override double perimeter()
        {
            Perimeter = Length * 4;
            return Length;
        }

        public override void InfoFigure()
        {
            Console.WriteLine("Фигура: квадрат");
            base.InfoFigure();
        }
    }
}