using System;
using System.Globalization;

namespace Exercicio1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, velocidadeMedia;
            double litros;

            horas = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            litros = (double) horas * velocidadeMedia / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}