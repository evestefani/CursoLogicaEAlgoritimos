using System;

namespace ExerciciosPropostosParte03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resultado, resto, cedulas;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            cedulas = 100;
            resultado = resto / cedulas;
            resto = resto % cedulas;
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ",00");

            cedulas = 50;
            resultado = resto / cedulas;
            resto = resto % cedulas;
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ",00");

            cedulas = 20;
            resultado = resto / cedulas;
            resto = resto % cedulas;
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ",00");

            cedulas = 10;
            resultado = resto / cedulas;
            resto = resto % cedulas;
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ",00");

            cedulas = 5;
            resultado = resto / cedulas;
            resto = resto % cedulas;
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ",00");

            cedulas = 2;
            resultado = resto / cedulas;
            resto = resto % cedulas;
            Console.WriteLine(resultado + " nota(s) de R$ " + cedulas + ",00");

            Console.WriteLine(resto + " nota(s) de R$ 1,00");

            Console.ReadLine();
        }
    }
}