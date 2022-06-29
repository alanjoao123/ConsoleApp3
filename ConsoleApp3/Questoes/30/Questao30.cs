using System;


namespace ConsoleApp3.Questoes._30
{
    public class Questao30
    {
        public static void TipoTriangulo()
        {
            float l1, l2, l3;

            Console.WriteLine(" OLÁ, Vamos verificar o tipo de Triângulo!\n");
            Console.WriteLine(" * Triângulo EQUILATERO todos os lados iguais \n * Triângulo ISÓSCELES dois lados iguais. \n * Triângulo ESCALENO todos os lados diferentes. \n");

            Console.WriteLine(" Digite o tamanho do primeiro lado");
            l1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o tamanho do segundo lado");
            l2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o tamanho do terceiro lado");
            l3 = float.Parse(Console.ReadLine());

            if ((l1 == l2) || (l2 == l3) || (l3 == l1))
            {
                Console.WriteLine(" O tamanho dos lados formam um TRIANGULO EQUILATERO");
            }
            else if ((l1 == l2) && (l2 == l3) && (l3 == l1))
            {
                Console.WriteLine("  O tamanho dos lados formam um TRIANGULO ISÓSCELES");
            }
            else if ((l1 != l2) || (l2 != l3) || (l3 != l1))
            {
                Console.WriteLine("  O tamanho dos lados formam um TRIANGULO ESCALENO");
            }
            else
            {
                Console.WriteLine(" Os dados não formam um TRIÂNGULO");
            }

            Console.ReadKey();  
        }

    }
}