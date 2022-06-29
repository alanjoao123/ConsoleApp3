using System;


namespace ConsoleApp3.Questoes._29
{
    public class Questao29
    {
        public static void ReajusteSalario()
        {
            double salAtual, tempserv, novosal;
            string nome;
            Console.WriteLine(" OLÁ, Vamos verificar de Quanto será seu Reajuste Salarial!\n");
            Console.WriteLine(" * Até 3 anos de Empresa Aumento de 3%. \n * Entre 3 e 10 Anos de Empresa Aumento de 12.5% . \n * Acima de 10 Anos de Empresa Aumento de 20%. \n");

            Console.WriteLine(" Digite o Nome do Funcionario");
            nome = Console.ReadLine();

            Console.WriteLine(" Digite o Salario Atual do {0}.", nome);
            salAtual = double.Parse(Console.ReadLine());
            Console.WriteLine(" Há Quantos Anos o Funcionario {0} Trabalha na Empresa", nome);
            tempserv = double.Parse(Console.ReadLine());

            if (tempserv <= 3)
            {
                novosal = salAtual + (salAtual * 3) / 100;
                Console.WriteLine(" O Novo Salario do Funcionario {0} será de R$ {1} Reais." , nome, novosal);
            }
            else if (tempserv >= 10)
            {
                novosal = salAtual + (salAtual * 12.5) / 100;
                Console.WriteLine(" O Novo Salario do Funcionario {0} será de R$ {1} Reais.", nome, novosal);

            }
            else
            {
                novosal = salAtual + (salAtual * 20) / 100;
                Console.WriteLine(" O Novo Salario do Funcionario {0} será de R$ {1} Reais.", nome, novosal);

            }
            Console.ReadKey();

        }

    }
}
