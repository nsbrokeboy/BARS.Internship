using System;

namespace BARS.Internship.Task4.Figure
{
    public abstract class Figure
    {
        public double Length { get; set; }
        
        public double Area { get; set; }
        
        public double Perimeter { get; set; }

        protected Figure(double length)
        {
            Length = length;
            area();
            perimeter();
        }

        public abstract double area();
        
        public abstract double perimeter();

        public virtual void InfoFigure()
        {
            Console.WriteLine(
                $"Длина стороны фигуры:{Length}\nПлощадь фигуры: {Area}\nПериметр фигуры: {Perimeter}");
        }
    }
}