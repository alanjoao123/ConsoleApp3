using System;

namespace ConsoleApp3.Questoes._16
{
    public  class Questao16
    {
        public static void CalculaDiasAMenos()
        {
            int quantidadecigarros, anosfumando;
            float dias, anos, minutos, diasperdidos, totalcigarros;

            Console.Write(" Quantidade de cigarros por dia: ");
            quantidadecigarros = int.Parse(Console.ReadLine());
            Console.Write(" Quantos anos Fumando: ");
            anosfumando = int.Parse(Console.ReadLine());

            //calculo dos anos

            dias = anosfumando * 365;
            totalcigarros = dias * quantidadecigarros;

            //calculo dos dias, horas,minutos

            minutos = totalcigarros * 10;
            diasperdidos = minutos / 1440;

            Console.WriteLine(" Quantidade de tempo de vida perdida {0} Dias.", dias);
            Console.ReadLine();
        }
    }
}
