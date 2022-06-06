namespace BARS.Internship.Task1.Motorcycle
{
    public class MotorcycleTestClass
    {
        public static void Main(string[] args)
        {
            var motoWithDriverIntensity = new Motorcycle("driver intensity 1");

            var motoWithDriverName = new Motorcycle();
            motoWithDriverName.SetDriverName("driver");

            var motoFullParams = new Motorcycle("driver2", "driver intensity 2");
        }
    }
}