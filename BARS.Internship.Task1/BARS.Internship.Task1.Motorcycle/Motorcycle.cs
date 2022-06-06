namespace BARS.Internship.Task1.Motorcycle
{
    public class Motorcycle
    {
        public string name;

        public string driverIntensity;
        
        // т.к. была найдена ошибка, убрал конструктор с name, это поле проинициализирую через метод SetDriverName и добавлю пустой конструктор
        public Motorcycle()
        {
        }

        public Motorcycle(string driverIntensity)
        {
            this.driverIntensity = driverIntensity;
        }

        public Motorcycle(string name, string driverIntensity)
        {
            this.name = name;
            this.driverIntensity = driverIntensity;
        }

        // получился метод-сеттер для поля name
        public void SetDriverName(string name)
        {
            this.name = name;
        }
    }
}