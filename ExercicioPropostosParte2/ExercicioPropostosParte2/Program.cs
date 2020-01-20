using System;
using System.Globalization;

namespace ExercicioPropostosParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;
            double pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4.0 / 3) * pi * (Math.Pow(raio, 3.0));

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}