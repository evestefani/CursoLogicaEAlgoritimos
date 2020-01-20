using System;

namespace ExercicioUri1071Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            soma = 0;

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                max = x;
                min = y;
            }
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.ReadLine();
        }
    }
}