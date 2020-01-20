using System;
using System.Globalization;

namespace OperadorDeAtribuicaoCumulativa
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());
            conta = 50.0;
            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
                //+= conta recebe conta + operação, isso seria o mesmo que conta = conta + ...
                //porém de uma forma mais resumida e isso se chama operador de atribuição cumulativa.
            }
            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}