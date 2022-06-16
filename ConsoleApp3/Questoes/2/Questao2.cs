using System;

namespace ConsoleApp3.Questoes._2
{
    public class Questao2
    {
        public static void QualSeuNNome()
        {
            string nome;
            Console.Write(" Qual o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine(" Ola " + nome + " é um prazer te conhecer !");
            Console.ReadLine();
        }
    }
}
