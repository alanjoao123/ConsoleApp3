using System;

namespace ConsoleApp3.Questoes._9
{
    public class Questao9
    {
        public static void Dollar()
        {
            double valorReal, valorDolar;

            Console.Write(" Digite quantos Reais você tem na carteira em R$: ");
            valorReal = double.Parse(Console.ReadLine());
            valorDolar = valorReal / 3.45;

            Console.WriteLine("Você tem na carteira o valor de " + valorDolar + " dolares.");
            Console.ReadLine();
        }
    }
}
