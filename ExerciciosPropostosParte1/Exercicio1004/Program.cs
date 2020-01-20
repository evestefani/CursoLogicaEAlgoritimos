using System;

namespace Exercicio1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, prod;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            prod = A * B;

            Console.WriteLine("PROD = " + prod);

            Console.ReadLine();
        }
    }
}