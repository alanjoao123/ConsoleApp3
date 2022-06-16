using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Calculadora
    {
        public static void Calcular()
        {
            double num1, num2;
            int resul = 0;

            Console.Write(" Digite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write(" Digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Clear();

            while (resul != 5)
            {
                Console.WriteLine(" Para Somar digite 1 ");
                Console.WriteLine(" Para Subtrair digite 2 ");
                Console.WriteLine(" Para Dividir digite 3 ");
                Console.WriteLine(" Para Multiplicar digite 4 ");
                Console.WriteLine(" Para Sair digite 5 ");
                resul = int.Parse(Console.ReadLine());

                if (resul == 1)
                {
                    Console.WriteLine(" A Soma dos numeros é = {0} ", num1 + num2);
                }
                if (resul == 2)
                {
                    Console.WriteLine(" A Subtração dos numeros é = {0} ", num1 - num2);
                }
                if (resul == 3)
                {
                    Console.WriteLine(" A Divição dos numeros é = {0} ", num1 / num2);
                }
                if (resul == 4)
                {
                    Console.WriteLine(" A Multiplicação dos numeros é = {0} ", num1 * num2);
                }
                Console.ReadLine();
                Console.Clear();


            }



        }
    }
}
