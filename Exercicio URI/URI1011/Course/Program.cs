using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, volume;
            int raio;

            pi = 3.14159;
            raio = int.Parse(Console.ReadLine());
            volume = (double)(4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
        }
    }
}