using System;

namespace BARS.Internship.Task4.Credit
{
    public class Credit
    {
        private protected double _sum;

        public Credit(double sum)
        {
            this._sum = sum;
        }

        public virtual double Sum
        {
            set
            {
                if (value >= 0)
                {
                    _sum = value;
                }
                else
                {
                    throw new ArithmeticException("Сумма должна быть >= 0");
                }
            }
            
            get => _sum;
        }
    }
}