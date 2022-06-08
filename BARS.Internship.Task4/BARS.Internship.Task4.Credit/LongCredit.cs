using System;

namespace BARS.Internship.Task4.Credit
{
    public class LongCredit : Credit
    {
        public override double Sum
        {
            set
            {
                if (value >= 100000)
                {
                    _sum = value;
                }
                else
                {
                    throw new ArithmeticException("Сумма longCredit должна быть >= 100000");
                }
            }
            
            get => _sum;
        }

        public LongCredit(double sum) : base(sum)
        {
        }
    }
}