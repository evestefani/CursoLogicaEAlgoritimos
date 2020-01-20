using System;
using System.Globalization;

namespace ExercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            //minha resolução já passando valores pre definidos
            //double largura = 10.0;
            //double comprimento = 30.0;
            //double valorm2 = 200.00;

            //var area = largura * comprimento;
            //var preco = area * valorm2;
             
            //Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Preco = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            //Console.ReadLine();

            //resolução do professor sem valores pre definidos, eles serão passados na aplicação
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
