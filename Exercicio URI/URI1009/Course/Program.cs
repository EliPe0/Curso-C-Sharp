using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, vendasTotal, salarioTotal;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            vendasTotal = double.Parse(Console.ReadLine());

            salarioTotal = salarioFixo + (double)(vendasTotal * 0.15);

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2"));
        }
    }
}