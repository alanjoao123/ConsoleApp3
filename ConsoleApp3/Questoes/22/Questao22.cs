using System;
using System.Runtime;

namespace ConsoleApp3.Questoes._22
{
    public class Questao22
    {
        public static void Alistamento()
        {
            Console.WriteLine(" Qual o ano do seu nascimento. (dd/MM/aaaa) ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

   
            DateTime dataAtual = DateTime.Now;

            var idade:int = dataAtual.Year - dataNascimento.Year;

            if (idade < 18)
            {
                Console.WriteLine(" Você não tem 18 anos. Falta {} anos. ", idade);
            }
            else if (idade == 18)
            {
                Console.WriteLine(" Você te que se alistar. ", idade);
            }
            else
            {
                Console.WriteLine(" Já passou do tempo do alistamento por {} anos ", idade);
            }
            Console.ReadLine();
        }
      
    }
}
