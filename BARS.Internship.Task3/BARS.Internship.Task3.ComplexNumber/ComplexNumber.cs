using System;

namespace BARS.Internship.Task3.ComplexNumber
{
    public class ComplexNumber
    {
        // todo 
        public double xCoef { get; set; }
        
        public double yCoef { get; set; }

        public ComplexNumber(double xCoef, double yCoef)
        {
            this.xCoef = xCoef;
            this.yCoef = yCoef;
        }

        public static ComplexNumber operator +(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(complexNumber1.xCoef + complexNumber2.xCoef,
                complexNumber1.yCoef + complexNumber2.yCoef);
        }

        public static ComplexNumber operator -(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(complexNumber1.xCoef - complexNumber2.xCoef,
                complexNumber1.yCoef - complexNumber2.yCoef);
        }
        
        public static ComplexNumber operator *(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(
                complexNumber1.xCoef * complexNumber2.xCoef - complexNumber1.yCoef * complexNumber2.yCoef,
                complexNumber1.xCoef * complexNumber2.yCoef + complexNumber1.yCoef * complexNumber2.xCoef);
        }

        public static ComplexNumber operator /(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(
                (complexNumber1.xCoef * complexNumber2.xCoef + complexNumber1.yCoef * complexNumber2.yCoef) / (Math.Pow(complexNumber2.xCoef, 2) + Math.Pow(complexNumber2.yCoef, 2)),
                (complexNumber2.xCoef * complexNumber1.yCoef - complexNumber1.xCoef * complexNumber2.yCoef) / (Math.Pow(complexNumber2.xCoef, 2) + Math.Pow(complexNumber2.yCoef, 2)));
        }

        public override string ToString()
        {
            if (yCoef < 0)
            {
                return $"z = {xCoef}{yCoef}i";
            }
            
            if (yCoef == 0)
            {
                return $"z = {xCoef}";
            }

            return $"z = {xCoef}+{yCoef}i";
        }
    }
}