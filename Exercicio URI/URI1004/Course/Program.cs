using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            int prod = A * B;

            Console.WriteLine("PROD = " + prod);
        }
    }
}