using System;
using System.Globalization;

namespace Exercicio1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco;

            String[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                preco = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                preco = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                preco = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                preco = quantidade * 2.0;
            }
            else
            {
                preco = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}