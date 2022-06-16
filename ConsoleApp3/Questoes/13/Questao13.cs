using System;

namespace ConsoleApp3.Questoes._13
{
    public class Questao13
    {
        public static void AumentoSalario()
        {
            double salario, aumento;
            string nome;

            Console.Write(" Digite o nome do Funcionario: ");
            nome = Console.ReadLine();
            Console.Write(" Por favor, Digite o Salário do Funcionario: ");
            salario = double.Parse(Console.ReadLine());
            aumento = salario + (salario * 15 / 100);

            Console.WriteLine(" O Funcionario {0} teve um aumento de 15% no seu salário.\n O valor do salário atual é  R$ {1} Reis.", nome, aumento);
            Console.ReadLine();
        }
    }
}
