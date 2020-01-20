using System;
using System.Globalization;

namespace Exercicio1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int resultado, resto, cedulas, moedas;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int)(N * 0.5 + 100.0);

            Console.WriteLine("NOTAS:");

            cedulas = 100;
            resultado = resto / (cedulas * 100);
            resto = resto % (cedulas * 100);
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ".00");

            cedulas = 50;
            resultado = resto / (cedulas * 100);
            resto = resto % (cedulas * 100);
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ".00");

            cedulas = 20;
            resultado = resto / (cedulas * 100);
            resto = resto % (cedulas * 100);
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ".00");

            cedulas = 10;
            resultado = resto / (cedulas * 100);
            resto = resto % (cedulas * 100);
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ".00");

            cedulas = 5;
            resultado = resto / (cedulas * 100);
            resto = resto % (cedulas * 100);
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ".00");

            cedulas = 2;
            resultado = resto / (cedulas * 100);
            resto = resto % (cedulas * 100);
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ".00");

            Console.WriteLine("MOEDAS:");

            moedas = 100;
            resultado = resto / moedas;
            resto = resto % moedas;
            Console.WriteLine(resultado + " moeda(s) de R$ 1.00");

            moedas = 50;
            resultado = resto / moedas;
            resto = resto % moedas;
            Console.WriteLine(resultado + " moeda(s) de R$ 0.50");

            moedas = 25;
            resultado = resto / moedas;
            resto = resto % moedas;
            Console.WriteLine(resultado + " moeda(s) de R$ 0.25");

            moedas = 10;
            resultado = resto / moedas;
            resto = resto % moedas;
            Console.WriteLine(resultado + " moeda(s) de R$ 0.10");

            moedas = 5;
            resultado = resto / moedas;
            resto = resto % moedas;
            Console.WriteLine(resultado + " moeda(s) de R$ 0.05");

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");

            Console.ReadLine();
        }
    }
}