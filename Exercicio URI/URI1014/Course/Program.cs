using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometro = int.Parse(Console.ReadLine());
            double consumo = double.Parse(Console.ReadLine());

            double consumoTotal = kilometro / consumo;

            Console.WriteLine(consumoTotal.ToString("F3") + "km/l");

        }
    }
}