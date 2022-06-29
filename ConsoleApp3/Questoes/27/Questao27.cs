using System;


namespace ConsoleApp3.Questoes._27
{
    public class Questao27
    {
        public static void MediaAluno()
        {
            string nome;
            float nota1, nota2, media;

            Console.WriteLine(" Qual o seu nome do Aluno? ");
            nome = Console.ReadLine();

            Console.WriteLine(" Digite a primeira nota do Aluno {0}", nome);
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a segunda nota do aluno {0} ", nome);
            nota2 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media <= 4.9)
            {
                Console.WriteLine(" A Média do aluno {0} foi de {1} Pontose está REPROVADO ", nome, media);
            }
            else if (media <= 6.9)
            {
                Console.WriteLine(" A Média do aluno {0} foi de {1} Pontos e está em RECUPERAÇÃO ", nome, media);
            }
            else
            {
                Console.WriteLine(" A Média do aluno {0} foi de {1} Pontos e está APROVADO", nome, media);
            }
            Console.ReadKey();
        }
    }
}
