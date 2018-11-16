using System;

namespace CourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анастасия Зайцева");
            City ivanovo = new City();          // вызов 1-ого
            City moscow = new City("Москва", "Россия");     // вызов 2-ого
            City peter = new City("Питер", "Россия", 9000);  // вызов 3-ого


            ivanovo.GetInfo();

            ivanovo.Population = 5;
            Console.WriteLine(ivanovo.Name);
            ivanovo.GetInfo();
            ivanovo.Population = -1;

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
