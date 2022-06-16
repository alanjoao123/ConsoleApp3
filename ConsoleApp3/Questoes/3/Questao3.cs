using System;

namespace ConsoleApp3.Questoes._3
{
    public class Questao3
    {
        public static void CaslcularSalario()
        {
            string nome;
            double salario;


            Console.Write(" Nome do Funcionario: ");
            nome = Console.ReadLine();
            Console.Write(" Salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine(" Funcionario(a) " + nome + " tem um salário de " + salario + " reais em junho. ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
