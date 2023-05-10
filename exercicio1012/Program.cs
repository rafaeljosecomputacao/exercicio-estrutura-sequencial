using System;
using System.Globalization;

namespace exercicio1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi = 3.14159, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            TRIANGULO = (A * C) / 2.0;
            CIRCULO = pi * (Math.Pow(C, 2.0));
            TRAPEZIO = ((A + B) * C) / 2.0;
            QUADRADO = Math.Pow(B, 2.0);
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}