namespace BARS.Internship.Task3.MathLib
{
    class MathLib
    {
        //   .field public static literal float64 PI = float64(3.141)
        public const double PI = 3.141;
        
        //  .field public static literal float64 E = float64(2.81)
        public const double E = 2.81;

        // .field public float64 K      - если убрать const
        // константа должна быть инициализирована т.к. потом задать ей значение нельзя
        // public const double K;

        public readonly int num = 5;

        public static readonly int num2;

        private readonly int num3;
        
        public int Num3
        {
            get => num3;
            init
            {
                num3 = 5;
            }
        }

        static MathLib()
        {
            num2 = 5;
        }
        
        public int GetSum(int a)
        {
            // [0] int32 V_0
            const int x = 32;
            
            return a + x;
        }
    }
}