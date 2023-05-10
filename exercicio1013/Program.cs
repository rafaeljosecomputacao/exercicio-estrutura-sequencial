using System;

namespace exercicio1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maior;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}