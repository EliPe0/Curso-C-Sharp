using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, hora;
            double salarioHora, salarioTotal;

            numeroFuncionario = int.Parse(Console.ReadLine());
            hora = int.Parse(Console.ReadLine());
            salarioHora = double.Parse(Console.ReadLine());

            salarioTotal = hora * salarioHora;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2"));
        }
    }
}