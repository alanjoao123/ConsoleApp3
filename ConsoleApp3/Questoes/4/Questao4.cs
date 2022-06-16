using System;

namespace ConsoleApp3.Questoes._4
{
    public  class Questao4
    {
        public static void Soma()
        {
            int a, b, soma;


            Console.Write(" Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" Digite outro numero: ");
            b = int.Parse(Console.ReadLine());
            soma = a + b;

            Console.WriteLine(" A Soma entre " + a + " + " + b + " é igual a " + soma + ".");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
