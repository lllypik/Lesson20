using System;

namespace Task
{
    class Program
    {
        delegate double MyDelegate(double radius);

        static void Main(string[] args)
        {

            Console.WriteLine("Введите радиус");
            double radius = Convert.ToDouble(Console.ReadLine());

            MyDelegate circumference = GetCircumference;
            Console.WriteLine($"Длина окружности с радиусом {radius} составляет {circumference(radius)}");

            circumference = GetVolumeOfSphere;
            Console.WriteLine($"Длина окружности с радиусом {radius} составляет {circumference(radius)}");

            circumference = GetAreaOfCircle;
            Console.WriteLine($"Длина окружности с радиусом {radius} составляет {circumference(radius)}");

            Console.ReadLine();

        }

        static double GetCircumference(double radius) => 2 * radius * Math.PI;
        static double GetVolumeOfSphere(double radius) => 4.0 / 3 * radius * radius * radius * Math.PI;
        static double GetAreaOfCircle(double radius) => radius * radius * Math.PI;


    }
}
