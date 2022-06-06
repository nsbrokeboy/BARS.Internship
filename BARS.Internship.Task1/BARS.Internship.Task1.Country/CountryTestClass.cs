using System;

namespace BARS.Internship.Task1.Country
{
    public class CountryTestClass
    {
        public static void Main(string[] args)
        {
            var state = new State()
            {
                name = "state1",
                
                country = new Country()
                {
                    name = "country1"
                }
            };

            var countryFirst = new Country()
            {
                name = "country2"
            };

            // расположение объектов в памяти изображено в файле memory.png
            
            
            State state1 = new State();
            state1.country = new Country();
            state1.name = "name1";

            State state2 = new State();
            state2.country = new Country();
            state2 = state1;

            state1.name = "(* ^ ω ^)";
            Console.WriteLine($"для struct\n1: {state1.name}\t2: {state2.name}\n");

            Country country1 = new Country();
            country1.name = "name1";

            Country country2 = new Country();
            country2 = country1;
            
            country1.name = "(* ^ ω ^)";
            Console.WriteLine($"для class\n1: {country1.name}\t2: {country2.name}\n");

            
            state1 = new State();
            state2 = new State();

            state2.country = new Country();
            state2.country.name = "5";
            state1 = state2;
            state2.country.name = "8";
            Console.WriteLine($"для class в struct\n1: {state1.country.name}\t2: {state2.country.name}\n");

            // рисунок того, как хранятся данные, аналогичен тому что в memory.png, думаю нет смысла перерисовывать
        }
    }
}