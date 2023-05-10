using System;
using System.Globalization;

namespace exercicio1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, raio, area;

            n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (Math.Pow(raio, 2.0));

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}