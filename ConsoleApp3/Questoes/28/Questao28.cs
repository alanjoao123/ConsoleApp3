using System;


namespace ConsoleApp3.Questoes._28
{
    public class Questao28
    {
        public static void MedidasTerreno()
        {
            float larg, comp, area;

            Console.WriteLine(" OLÁ, Vamos verificar a classificação do seu Terreno!\n");
            Console.WriteLine(" * Terrenos abaixo de 100mts é um TERRENO POPULAR. \n * Terrenos entre 100mts e 500mts é um TERRENO MASTER. \n * Terrenos acima de 500mts é um TERRENO VIP. \n");

            Console.WriteLine(" Agora Digite o Comprimento do seu terreno em Metros");
            comp = float.Parse(Console.ReadLine());
            Console.WriteLine(" Agora Digite a Largura do seu terreno em Metros");
            larg = float.Parse(Console.ReadLine());

            area = larg * comp;

            if (area <= 100)
            {
                Console.WriteLine(" Seu Terreno possui uma Area de {0} Metros e está Classificado como TERRENO POPULAR  ", area);
            }
            else if (area <= 500)
            {
                Console.WriteLine(" Seu Terreno possui uma Area de {0} Metros e está Classificado como TERRENO MASTER  ", area);
            }
            else
            {
                Console.WriteLine(" Seu Terreno possui uma Area de {0} Metros e está Classificado como TERRENO VIP ", area);
            }
            Console.ReadKey();

        }

    }
}