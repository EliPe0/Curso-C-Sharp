using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;

            A = 2 * double.Parse(Console.ReadLine());
            B = 3 * double.Parse(Console.ReadLine());
            C = 5 * double.Parse(Console.ReadLine());

            media = (double)(A + B + C) / 10.0;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}