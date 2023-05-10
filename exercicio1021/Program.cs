using System;
using System.Globalization;

namespace exercicio1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorMonetario;
            int quociente, resto, nota, moeda;

            valorMonetario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //multiplicar o valor monetário por 100 e forçar a conversão para
            //int, assim 576.73 vai se tornar 57673 e somar 0.5 antes de
            //converter, assegurando que o valor monetário seja arredondado 
            resto = (int)(valorMonetario * 100 + 0.5);

            //como o valor monetário foi multiplicado por 100, o valor de cada
            //nota deve ser multiplicado por 100 também
            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            //o valor de cada moeda deve ser apresentado em centavos
            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}