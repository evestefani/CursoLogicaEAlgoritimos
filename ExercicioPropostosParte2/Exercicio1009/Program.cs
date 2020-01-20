using System;
using System.Globalization;

namespace Exercicio1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salarioFixo, vendas, salarioComComissao;

            vendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioComComissao = vendas * 15.0 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + salarioComComissao.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}