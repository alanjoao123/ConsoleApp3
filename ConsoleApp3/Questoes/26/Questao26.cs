﻿using System;


namespace ConsoleApp3.Questoes._26
{
    internal class Questao26
    {
        public static void ComparadorNumeros()
        {
            int n1, n2;

            Console.WriteLine(" Digite o Primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o Segundo Numero: ");
            n2 = int.Parse(Console.ReadLine());


            if (n1 > n2)
            {
                Console.WriteLine(" O Primeiro valor é maior");
            }
            else if (n2 > n1)
            {
                Console.WriteLine(" O Segundo valor é maior");
            }
            else
            {
                Console.WriteLine(" Não existe valor maior, os dois são iguais");
            }
            Console.ReadKey();



        }   
    }
}
