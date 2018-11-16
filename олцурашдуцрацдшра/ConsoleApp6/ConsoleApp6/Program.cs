using System;

namespace CourseApp
{
    class City
    {
        public string country; 
        public int population;
        public string name;

        public City() { name = "Иваново"; country = "Россия"; population = 316 ; }      // 1 конструктор

        public City(string n, string m) { name = n; country = m; population = 11000; }         // 2 конструктор

        public City(string n, string m, int a) { name = n; country = m; population = a; }
        public void GetInfo()
        {
            Console.WriteLine($"Название: {name}  Страна: {country}  Популяция: {population}");
        }
        public void s(int pop)
        {
            population += pop;
        }
        public void Ueh()
        {
            Console.WriteLine($"Из-за ужасной ядерной катастрофы всё население Иванова вымерло");
        }

    }
    class Program
    {
        static void Main(string[] args)
        { 
        City ivanovo = new City();          // вызов 1-ого конструктора без параметров
        City moscow = new City("Москва", "Россия");     //вызов 2-ого конструктора с одним параметром
        City peter = new City("Питер", "Россия", 9000);
        
         
            ivanovo.GetInfo();
            moscow.GetInfo();
            peter.GetInfo();


            ivanovo.s(100);
            ivanovo.GetInfo();

            ivanovo.Ueh();

            Console.Read();
        }
    }
}