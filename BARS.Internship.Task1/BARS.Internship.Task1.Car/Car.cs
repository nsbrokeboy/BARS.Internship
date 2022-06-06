namespace BARS.Internship.Task1.Car
{
    public class Car
    {
        public string nameOfAuto;

        public double maxSpeed;

        public Car(string nameOfAuto)
        {
            this.nameOfAuto = nameOfAuto;
        }

        public Car(double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public Car(string nameOfAuto, double maxSpeed)
        {
            this.nameOfAuto = nameOfAuto;
            this.maxSpeed = maxSpeed;
        }
    }
}
