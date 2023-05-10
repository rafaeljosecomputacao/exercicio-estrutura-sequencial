using System;
using System.Globalization;

namespace exercicio1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, V, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            V = (4 / 3.0) * pi * (Math.Pow(R, 3.0));

            Console.WriteLine("VOLUME = " + V.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}