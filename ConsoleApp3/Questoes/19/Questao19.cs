using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Questoes._19
{
    public class Questao19
    {
        public static void SituacaoDoAluno()
        {
            float nota1, nota2, nota3, media;
            string resultado;



            Console.Write(" Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write(" Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write(" Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            media = ((nota1 + nota2 + nota3) / 3);


            if (media < 5)
            {
                resultado = "Reprovao";
            }
            else if (media < 7)
            {
                resultado = " bom aproveitamento, mas ta de recuperação!";
            }
            else
            {
                resultado = " Aprovado. ";

            }



            Console.WriteLine(" Nota: {0} - Resultado: {1}", media, resultado);



            Console.ReadKey();
        }
    }
}
