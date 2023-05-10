using System;
using System.Globalization;

namespace exercicio1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, HOURS;
            double VALUE, SALARY;

            NUMBER = int.Parse(Console.ReadLine());
            HOURS = int.Parse(Console.ReadLine());
            VALUE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = HOURS * VALUE;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}