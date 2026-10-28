using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, n, raio;

            raio = double.Parse(Console.ReadLine());
            n = 3.14159;
            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}