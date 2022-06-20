using System;

namespace ConsoleApp3.Questoes._21
{
    public class Questao21
    {
        public static void AnoBissexto()
        {
            int ano;



            Console.Write(" Digite o Ano: ");
            ano = int.Parse(Console.ReadLine());


            if (ano % 4 == 0)
            {
                Console.WriteLine(" Ano Bissexto ");
            }
            else
            {
                Console.WriteLine(" Não é Ano Bissexto");
            }

            Console.ReadKey();
        }
    }
}
