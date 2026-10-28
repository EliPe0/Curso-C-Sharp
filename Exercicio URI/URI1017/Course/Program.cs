using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int consumoMedio = 12;

            int hora = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            double consumo = hora * velocidadeMedia;
            double distanciaPercorrida = consumo / consumoMedio;

            Console.WriteLine(distanciaPercorrida.ToString("F3"));
        }
    }
}