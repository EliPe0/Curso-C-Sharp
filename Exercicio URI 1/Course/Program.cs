using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1000 - Hello World"
             * Console.WriteLine("Hello World!");
             */

            /* 1001 - Extremamente Básico
             * int A, B, X;
             * 
             * A = int.Parse(Console.ReadLine());
             * B = int.Parse(Console.ReadLine());
             * 
             * X = A + B;
             * 
             * Console.WriteLine("X = " + X);
             */

            /* 1002 - Área do Círculo
             * double area, n, raio;
             * 
             * raio = double.Parse(Console.ReadLine());
             * n = 3.14159;
             * area = n * (raio * raio);
             * 
             * Console.WriteLine("A=" + area.ToString("F4"));
             */

            /* 1003 - Soma Simples
             * int A, B;
             * 
             * A = int.Parse(Console.ReadLine());
             * B = int.Parse(Console.ReadLine());
             * 
             * int soma = A + B;
             * 
             * Console.WriteLine("SOMA = " + soma);
             */

            /* 1004 - Produto Simples
             * int A, B;
             * 
             * A = int.Parse(Console.ReadLine());
             * B = int.Parse(Console.ReadLine());
             * 
             * int prod = A * B;
             * 
             * Console.WriteLine("PROD = " + prod);
             */

            /* 1005 - Média 1
             * double A, B, media;
             * A = 3.5 * double.Parse(Console.ReadLine());
             * B = 7.5 * double.Parse(Console.ReadLine());
             * 
             * media = (A + B) / 11;
             * 
             * Console.WriteLine("MEDIA = " + media.ToString("F5"));
             */

            /* 1006 - Média 2
             * double A, B, C, media;
             * A = 2 * double.Parse(Console.ReadLine());
             * B = 3 * double.Parse(Console.ReadLine());
             * C = 5 * double.Parse(Console.ReadLine());
             * 
             * media = (A + B + C) / 10;
             * 
             * Console.WriteLine("MEDIA = " + media.ToString("F1"));
             */

            /* 1007 - Diferença
             * int A, B, C, D, diferenca;
             * 
             * A = int.Parse(Console.ReadLine());
             * B = int.Parse(Console.ReadLine());
             * C = int.Parse(Console.ReadLine());
             * D = int.Parse(Console.ReadLine());
             * 
             * diferenca = (A * B - C * D);
             * 
             * Console.WriteLine("DIFERENCA = " + diferenca);
             */

            /* 1008 - Salário
             * int numeroFnuncionario, hora;
             * double salarioHora, salarioTotal;
             * 
             * numeroFuncionario = int.Parse(Console.ReadLine());
             * hora = int.Parse(Console.ReadLine());
             * salarioHora = double.Parse(Console.ReadLine());
             * 
             * salarioTotal = hora * salarioHora;
             * 
             * Console.WriteLine("NUMBER = " + numeroFuncionario);
             * Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2"));
             */

            /* 1009 - Salário com Bônus
             * string nomeVendedor;
             * double salarioFixo, totalVendas, salarioTotal;
             * 
             * nomeVendedor = Console.ReadLine();
             * salarioFixo = dpouble.Parse(Console.ReadLine());
             * vendasTotal = double.Parse(Console.ReadLine());
             * salarioTotal = salarioFixo + (vendasTotal * 0.15);
             * 
             * Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2"));
             */

            /* 1010 - Cálculo Simples
             * double valorTotal;
             * 
             * string[] produto = Console.ReadLine().Split(' ');
             * int codigoProduto = int.Parse(produto[0]);
             * int unidade = int.Parse(produto[1]);
             * double valor = double.Parse(produto[2]);
             * 
             * string[] produto2 = Console.ReadLine().Split(' ');
             * int codigoProduto2 = int.Parse(produto2[0]);
             * int unidade2 = int.Parse(produto2[1]);
             * double valor2 = double.Parse(produto2[2]);
             * 
             * valorTotal = unidade * valor + unidade2 * valor2;
             * 
             * Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2"));
             */

            /* 1011 - Esfera
             * double pi, volume;
             * int raio;
             * 
             * pi = 3.14159;
             * raio = int.Parse(Console.ReadLine());
             * volume = (4 / 3.0) * pi * Math.Pow(raio, 3);
             * 
             * Console.WriteLine("VOLUME = " + volume.ToString("F3"));
             */

            /* 1014 - Consumo
             * int kilometro = iint.Parse(Console.ReadLine());
             * double consumo = double.Parse(Console.ReadLine());
             * 
             * double consumoTotal = kilometro / consumo;
             * 
             * Console.WriteLine(consumoTotal.ToString("F3") + " km/l");
             */

            /* 1016 - Distância
             * int distancia = int.Parse(Console.ReadLine());
             * 
             * int tempo = distancia * 2;
             * 
             * Console.WriteLine(tempo + " minutos");
             */

            /* 1017 - Gasto de Combustível
             * int consumoMedio = 12;
             * 
             * int hora = int.Parse(Console.ReadLine());
             * int velocidadeMedia = int.Parse(Console.ReadLine());
             * 
             * double consumo = hora * velocidadeMedia;
             * double distanciaPercorrida = consumo / consumoMedio;
             * 
             * Console.WriteLine(distanciaPercorrida.ToString("F3"));
             */

        }
    }
}