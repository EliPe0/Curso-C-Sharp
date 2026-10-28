using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal;

            string[] produto = Console.ReadLine().Split(' ');
            int codigoProduto = int.Parse(produto[0]);
            int unidade = int.Parse(produto[1]);
            double valor = double.Parse(produto[2]);

            string[] produto2 = Console.ReadLine().Split(' ');
            int codigoProduto2 = int.Parse(produto[0]);
            int unidade2 = int.Parse(produto[1]);
            double valor2 = double.Parse(produto2[2]);

            valorTotal = unidade * valor + unidade2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2");
        }
    }
}