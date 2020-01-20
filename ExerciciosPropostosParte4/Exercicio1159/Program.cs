using System;

namespace Exercicio1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            X = int.Parse(Console.ReadLine());
            while (X != 0)
            {
                if (X % 2 != 0)
                {
                    X = X + 1;
                }
                int soma = 5 * X + 20;
                Console.WriteLine(soma);

                X = int.Parse(Console.ReadLine());
            }
        }
    }
}