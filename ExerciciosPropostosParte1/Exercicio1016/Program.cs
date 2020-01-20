using System;

namespace Exercicio1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, tempo;

            km = int.Parse(Console.ReadLine());

            tempo = km * 2;

            Console.WriteLine(tempo + " minutos");

            Console.ReadLine();
        }
    }
}