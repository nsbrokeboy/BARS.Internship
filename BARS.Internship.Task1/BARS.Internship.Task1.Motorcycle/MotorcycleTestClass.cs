namespace BARS.Internship.Task1.ChangedNamespace
{
    public class MotorcycleTestClass
    {
        public static void Main(string[] args)
        {
            // здесь я изменил неймспейс для 7 задания
            
            var motoWithDriverIntensity = new Motorcycle.Motorcycle("driver intensity 1");

            var motoWithDriverName = new Motorcycle.Motorcycle();
            motoWithDriverName.SetDriverName("driver");

            var motoFullParams = new Motorcycle.Motorcycle("driver2", "driver intensity 2");
        }
    }
}