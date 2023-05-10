using System;
using System.Globalization;

namespace exercicio1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, codigoPeca2, numeroPecas1, numeroPecas2;
            double valorPeca1, valorPeca2, valorAPagar;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vetor[0]);
            numeroPecas1 = int.Parse(vetor[1]);
            valorPeca1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            vetor = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vetor[0]);
            numeroPecas2 = int.Parse(vetor[1]);
            valorPeca2 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            valorAPagar = ((numeroPecas1 * valorPeca1) + (numeroPecas2 * valorPeca2));

            Console.WriteLine("VALOR A PAGAR: R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}