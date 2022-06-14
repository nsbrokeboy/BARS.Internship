using System;

namespace BARS.Internship.Task9.Geometry
{
    public static class Circle
    {
        public static double Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double Volume(double radius)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        }
    }
}