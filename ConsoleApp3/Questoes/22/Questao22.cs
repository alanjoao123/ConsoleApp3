using System;


namespace ConsoleApp3.Questoes._22
{
    public class Questao22
    {
        public static void Alistamento()
        {
            string nome;
            float idade, nascimento, maioid, menorid;

            Console.WriteLine(" Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine(" {0} Qual o seu ano de nascimento? ", nome);
            nascimento = float.Parse(Console.ReadLine());

            idade = 2022 - nascimento;

            if(idade < 18)
            {
                Console.WriteLine(" Você não tem 18 anos. falta alguns anos para você se Alistar.");
            }
            else if (idade == 18)
            {
                Console.WriteLine(" Você tem que se Alistar");
            }
            else
            {
                Console.WriteLine(" Já passou do seu tempo de Alistamento. Hoje você tem {0} anos", idade);
            }
            Console.ReadKey();
        }
    }
}