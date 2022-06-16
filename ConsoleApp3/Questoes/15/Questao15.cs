using System;

namespace ConsoleApp3.Questoes._15
{
    public class Questao15
    {
        public static void CalculaSalarioPorHora()
        {
            string nome;
            int dias;
            double salario, horas;

            Console.Write(" Qual o nome do Funcionario: ");
            nome = Console.ReadLine();
            Console.Write(" Quantos dias trabalhados: ");
            dias = int.Parse(Console.ReadLine());
            Console.Write(" Quantas horas no Mês o Funcionario trabalhou: ");
            horas = double.Parse(Console.ReadLine());


            salario = (dias * 30) + (horas * 20);

            Console.WriteLine(" O Funcionario {0} Trabalhou nesse mês {1} dias e {2} horas\n Seu Salário será de R$ {3} Reais. ", nome, dias, horas, salario);
            Console.ReadLine();
        }
    }
}
