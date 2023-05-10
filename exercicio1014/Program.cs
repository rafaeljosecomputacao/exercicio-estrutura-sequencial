using System;
using System.Globalization;

namespace exercicio1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, CM;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CM = X / Y;

            Console.WriteLine(CM.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}