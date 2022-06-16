using System;

namespace ConsoleApp3.Questoes._20
{
    public class Questao20
    {
        public static void ParOuImpar()
        {
            int numero, resultado;

            Console.Write(" Digite a primeira nota: ");
            numero = int.Parse(Console.ReadLine());

            resultado = numero % 2;

            if (resultado == 0)
            {
                Console.WriteLine(" É Par. ");
            }
            else
            {
                Console.WriteLine(" É impa. ");
            }

            Console.ReadKey();
        }
    }
}
