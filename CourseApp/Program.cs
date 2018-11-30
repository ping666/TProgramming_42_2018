using System;

namespace CourseApp
{
   public class Program
    {
        public static double formula(double x, double a, double b)
        {
            return (a + ((Math.Sin(b * x)) * (Math.Sin(b * x))) / ((Math.Cos(b * x)) * (Math.Cos(b * x)))) / (b + ((Math.Cos(a * x) * (Math.Cos(a * x)) / (Math.Sin(a * x) * (Math.Sin(a * x))))));

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Анастасия Зайцева");
            Console.WriteLine("вар 17");
            Console.WriteLine();
            Console.WriteLine("под А");
            double a = 0.1;
            double b = 0.5;
            double xn = 0.15;
            double xk = 1.37;
            double dx = 0.25;
            for (double x = xn; x <= xk; x = x + dx)
            {
                Console.WriteLine($" x={x} y={Math.Round(formula(x, a, b), 3)}");
            }
            Console.WriteLine();
            Console.WriteLine("под B");
            double[] z = new double[] { 0.2, 0.3, 0.44, 0.6, 0.56 };
            foreach (double element in z)
            {
                Console.WriteLine($" X={element} y={Math.Round(formula(element, a, b), 3)} ");
            }

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
