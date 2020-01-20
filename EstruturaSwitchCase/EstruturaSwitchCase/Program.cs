using System;

namespace EstruturaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            //string dia;

            //if (x == 1)
            //{
            //    dia = "domingo";
            //}
            //else if (x == 2)
            //{
            //    dia = "segunda";
            //}
            //else if (x == 3)
            //{
            //    dia = "terca";
            //}
            //else if (x == 4)
            //{
            //    dia = "quarta";
            //}
            //else if (x == 5)
            //{
            //    dia = "quinta";
            //}
            //else if (x == 6)
            //{
            //    dia = "sexta";
            //}
            //else if (x == 7)
            //{
            //    dia = "sabado";
            //}
            //else
            //{
            //    dia = "Valor inválido";
            //}

            //Console.WriteLine("Dia da semana: " + dia);
            //Console.ReadLine();

            //forma alternativa do código acima em switch case

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1: dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terca";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default: dia = "Valor invalido";
                    break;
            }
            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}