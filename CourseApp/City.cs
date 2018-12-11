using System;

namespace CourseApp
{
    public class City
    {
        public string Country { get; set; }
        private int population;
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

        public City() : this("Иваново", "Россия", 316) { }     // 1 конструктор

        public City(string name, string country): this(name, country, 11000) { }      // 2 конструктор

        public City(string name, string country, int population) { Name = name; Country = country; Population = population; }     // 3 конструктор
        public void GetInfo()
        {
            Console.WriteLine($"Название: {Name}  Страна: {Country}  Популяция: {population}");
        }
        public void s(int pop)
        {
            population += pop;
        }
        public void Ueh()
        {
            Console.WriteLine($"Из-за ужасной ядерной катастрофы всё население города вымерло");
        }

    }
}