using System;

namespace BARS.Internship.Task4.Figure
{
    public class Circle : Figure
    {
        /// <param name="length">Радиус круга</param>
        public Circle(double length) : base(length)
        {
        }

        public override double area()
        {
            Area = Math.PI * Math.Pow(Length, 2);
            return Area;
        }

        public override double perimeter()
        {
            Perimeter = 2 * Length * Math.PI;
            return Perimeter;
        }

        public new void InfoFigure()
        {
            Console.WriteLine($"Фигура: круг\nРадиус: {Length}\nДлина окружности: {Perimeter}\nПлощадь круга: {Area}");
        }
    }
}