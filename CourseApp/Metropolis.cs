using System;

namespace CourseApp
{
    public abstract class Metropolis
    {
        private int population;

        public Metropolis()
        {
        public class City
        {
            private int population;

            public City()
                : this("Иваново", "Россия", 316)
            {
            } // 1 конструктор

            public City(string name, string country)
                : this(name, country, 11000)
            {
            } // 2 конструктор

            public City(string name, string country, int population)
            {
                Name = name;
                Country = country;
                Population = population;
            } // 3 конструктор

            public string Country { get; set; }

            public string Name { get; set; }

            public int Population
            {
                get
                {
                    return population;
                }

                set
                {
                    if (value > 0)
                    {
                        this.population = value;
                    }
                }
            }

            public void GetInfo()
            {
                Console.WriteLine($"Название: {Name}  Страна: {Country}  Популяция: {population}");
            }

            public void AddPopulation(int pop)
            {
                population += pop;
            }

            public string Dead()
            {
                return $"Всё население города {Name} вымерло из-за аварии на АЭС.";
            }
        }
    }
}