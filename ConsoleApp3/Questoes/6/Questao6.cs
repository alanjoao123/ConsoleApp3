using System;

namespace ConsoleApp3.Questoes._6
{
    public  class Questao6
    {
        public static void AntecessorESucessor()
        {
            int num, antecessor, sucessor;

            Console.Write(" Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            antecessor = num - 1;
            sucessor = num + 1;

            Console.WriteLine(" O Antecessor de " + num + " é " + antecessor + ".");
            Console.WriteLine(" O Sucessor de " + num + " é " + sucessor + ".");

            Console.ReadLine();
        }
    }
}
