using System;

namespace ConsoleApp3.Questoes._18
{
    public class Questao18
    {
        public static void VotoObrigatorio()
        {
            float idade, nascimento, anoAtual;

            Console.Write(" Qual o ano do seu nascimento: ");
            nascimento = float.Parse(Console.ReadLine());

            Console.Write(" Qual o ano atual: ");
            anoAtual = float.Parse(Console.ReadLine());

            idade = anoAtual - nascimento;

            if (idade > 16 && idade <= 65)
            {
                Console.WriteLine(" {0} Anos! \n Obrigatorio votar. ", idade);
            }
            else
            {
                Console.WriteLine(" {0} Anos! \n Voto facultativo. ", idade);
            }

            Console.ReadLine();
        }
    }
}
