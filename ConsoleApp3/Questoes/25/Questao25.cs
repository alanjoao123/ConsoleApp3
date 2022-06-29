using System;


namespace ConsoleApp3.Questoes._25
{
    internal class Questao25
    {
        public static void Triângulos()
        {
            float r1, r2, r3;

            Console.WriteLine(" Digite o primeiro lado: ");
            r1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o segundo lado: ");
            r2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o terceiro lado: ");
            r3 = float.Parse(Console.ReadLine());   

            if ((r1 + r2 > r3) && (r2 + r3 > r1) && (r3 + r1 > r2)) 
            {
                Console.WriteLine(" O tamanho dos lados formam um triangulo");
            }
            else
            {
                Console.WriteLine(" O tamanho dos lados não formam um TRIÂNGULO");
            }
            Console.ReadKey();
        }
    }
}
