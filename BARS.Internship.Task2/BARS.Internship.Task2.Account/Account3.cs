namespace BARS.Internship.Task2.Account
{
    class Account3
    {
        private static decimal minSum = 100;

        // ошибка в том, что класс статический => члены его должны быть статическими, а свойства содается нестатическое
        
        // public decimal MinSum
        // {
        //     get { return minSum; }
        //     set { if(value>0) minSum = value; }
        // }

        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }

}