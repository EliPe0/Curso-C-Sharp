using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, media;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            media = (double)(A + B) / 11.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}