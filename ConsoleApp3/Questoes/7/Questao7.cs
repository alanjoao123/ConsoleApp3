using System;

namespace ConsoleApp3.Questoes._7
{
    public class Questao7
    {
        public static void Dobro()
        {
            float terca, dobro, numero;

            Console.Write("Digite um numero: ");
            numero = float.Parse(Console.ReadLine());
            terca = numero / 3;
            dobro = numero * 2;
            Console.WriteLine("O Dobro de " + numero + " é " + dobro);
            Console.WriteLine("A Terça parte de " + numero + " é " + terca);
            
            Console.ReadLine();
        }
    }
}
