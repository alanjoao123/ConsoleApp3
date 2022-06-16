using System;

namespace ConsoleApp3.Questoes._5
{
    public class Questao5
    {
        public static void MediaDaNota()
        {
            float a, b, media;
            string nome;


            Console.Write(" Nome do Aluno(a): ");
            nome = Console.ReadLine();
            Console.Write(" Nota 1: ");
            a = float.Parse(Console.ReadLine());
            Console.Write(" Nota 2: ");
            b = float.Parse(Console.ReadLine());
            media = (a + b) / 2;

            Console.WriteLine(" A Media do Aluno(a) " + nome + " é igual a " + media + ".");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
