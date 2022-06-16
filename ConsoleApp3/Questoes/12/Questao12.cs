using System;

namespace ConsoleApp3.Questoes._12
{
    public class Questao12
    {
        public static void CalcularDesconto()
        {
            double valorproduto, Valorfinal;

            Console.Write(" Por favor, Digite o Valor do Produto: ");
            valorproduto = double.Parse(Console.ReadLine());
            Valorfinal = valorproduto - (valorproduto * 5 / 100);

            Console.WriteLine(" COM 5 % de DESCONTO O VALOR FICOU POR: \n R$ {0} Reais.", Valorfinal);
            Console.ReadLine();
        }
    }
}
