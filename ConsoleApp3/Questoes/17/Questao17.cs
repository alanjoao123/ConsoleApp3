using System;

namespace ConsoleApp3.Questoes._17
{
    public class Questao17
    {
        public static void CalculaValorMulta()
        {
            float velocidade, multa;
            Console.Write(" Qual a velocidade do carro: ");
            velocidade = float.Parse(Console.ReadLine());

            multa = (velocidade - 80) * 5;

            if (velocidade > 80)
            {
                Console.WriteLine(" Você foi multado em R$ {0} Reais.", multa);
            }
            if (velocidade <= 80)
            {
                Console.WriteLine(" Sua velocidade está ok, boa viagem!");
            }

            Console.ReadLine();
        }
    }
}
