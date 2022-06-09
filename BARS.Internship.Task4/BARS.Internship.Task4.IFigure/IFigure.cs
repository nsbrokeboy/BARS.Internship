using System;

namespace BARS.Internship.Task4.IFigure
{
    public interface IFigure
    {
        public double Length { get; set; }
        
        public double Area { get; set; }
        
        public double Perimeter { get; set; }
        
        public double area();
        
        public double perimeter();

        public virtual void InfoFigure()
        {
            Console.WriteLine(
                $"Длина стороны фигуры:{Length}\nПлощадь фигуры: {Area}\nПериметр фигуры: {Perimeter}");
        }
    }
}