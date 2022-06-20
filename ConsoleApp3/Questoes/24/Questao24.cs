using System;


namespace ConsoleApp3.Questoes._24
{
    public class Questao24
    {
        public static void Passageiro()
        {
            int km;
            double dist200,dist201;

            Console.WriteLine(" Qual a distancia que você percorreu:  ");
            km = int.Parse(Console.ReadLine());

            dist200 = km * 0.50;
            dist201 = km * 0.45;

            if (km <= 200)
            {
                Console.WriteLine(" O valor da sua viagem será de R$ {0} Reais", dist200);
            }
            else
            {
                Console.WriteLine(" O valor da sua viagem será de R$ {0} Reais", dist201);
            }
            Console.ReadKey();
        }
    }
}
