using System;
using System.Globalization;

namespace UsandoOForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nome lidos: ");
            foreach (string item in vet)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}