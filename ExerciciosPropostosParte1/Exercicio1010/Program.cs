using System;
using System.Globalization;

namespace Exercicio1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, peca2, numeroPecas1, numeroPecas2;
            double precoPeca1, precoPeca2, valorPedido;

            string[] 
            pedidos = Console.ReadLine().Split(' ');
            peca1 = int.Parse(pedidos[0]);
            numeroPecas1 = int.Parse(pedidos[1]);
            precoPeca1 = double.Parse(pedidos[2], CultureInfo.InvariantCulture);

            pedidos = Console.ReadLine().Split(' ');
            peca2 = int.Parse(pedidos[0]);
            numeroPecas2 = int.Parse(pedidos[1]);
            precoPeca2 = double.Parse(pedidos[2], CultureInfo.InvariantCulture);

            valorPedido = precoPeca1 * numeroPecas1 + precoPeca2 * numeroPecas2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPedido.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}