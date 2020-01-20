using System;

namespace Exercicio1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, ehOMaior;

            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            maior = (a + b + Math.Abs(a - b)) / 2;

            ehOMaior = (maior + c + Math.Abs(maior - c)) / 2;

            Console.WriteLine(ehOMaior + " eh o maior");

            Console.ReadLine();
        }
    }
}