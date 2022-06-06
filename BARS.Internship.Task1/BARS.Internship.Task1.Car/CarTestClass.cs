using System;

namespace BARS.Internship.Task1.Car
{
    public class CarTestClass
    {
        public static void Main(string[] args)
        {
            var carWithName = new Car("Audi A6"); // только с именем, используя первый конструктор
            Console.WriteLine((string)carWithName.nameOfAuto);
            Console.WriteLine((double)carWithName.maxSpeed);

            Console.WriteLine("-------------------------------------");
            
            var carWithMaxSpeed = new Car(210); // только со скоростью, используя второй конструктор
            Console.WriteLine((string)carWithMaxSpeed.nameOfAuto);
            Console.WriteLine((double)carWithMaxSpeed.maxSpeed);
            
            Console.WriteLine("-------------------------------------");

            var carFullParameters =
                new Car("Mercedes-AMG S 63", 250); // с двумя параметрами, используя третий конструктор
            Console.WriteLine((string)carFullParameters.nameOfAuto);
            Console.WriteLine((double)carFullParameters.maxSpeed);

            // var carWithoutParams = new Car();
            // При попытке создать экземляр класса Car, используя конструктор без параметров, получим ошибку, т.к. пустой конструктор не создан 
        }
    }
}