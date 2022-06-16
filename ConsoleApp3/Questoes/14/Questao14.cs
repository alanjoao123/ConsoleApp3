using System;

namespace ConsoleApp3.Questoes._14
{
    public class Questao14
    {
        public static void CalculaValorAluguelCarro()
        {
            int dias;
            double km, pagamento;

            Console.Write(" Quantos dias Alugados: ");
            dias = int.Parse(Console.ReadLine());
            Console.Write(" Quantos Quilomentros rodados: ");
            km = double.Parse(Console.ReadLine());
            pagamento = (dias * 90) + (km * 0.20);

            Console.WriteLine(" Você percorreu {0} quilomentos em {1} dias.\n O valor a pagar será de:R$ {2} Reais", km, dias, pagamento);
            Console.ReadLine();
        }
    }
}
