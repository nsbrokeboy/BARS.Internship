using System;

namespace BARS.Internship.Task4.IFigure
{
    public class Square : IFigure
    {
        public double Length { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public Square(double length)
        {
            Length = length;
            area();
            perimeter();
        }

        public double area()
        {
            Area = Length * Length;
            return Area;
        }

        public double perimeter()
        {
            Perimeter = Length * 4;
            return Perimeter;
        }
        
        // ну и остальные классы подобным образом
    }
}