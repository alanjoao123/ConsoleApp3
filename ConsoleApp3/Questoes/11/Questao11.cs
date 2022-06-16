using System;

namespace ConsoleApp3.Questoes._11
{
    public class Questao11
    {
        public static void EquacaoSegundoGrau()
        {
            double delta, x1, x2;
            float a, b, c;

            Console.Write(" Digite o valor do numero A: ");
            a = float.Parse(Console.ReadLine());

            Console.Write(" Digite o valor do numero B: ");
            b = float.Parse(Console.ReadLine());

            Console.Write(" Digite o valor do numero C: ");
            c = float.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine();

            Console.WriteLine(" O valor de Delat é {0}: ", delta);
            Console.WriteLine(" O valor de X1 é {0}: ", x1);
            Console.WriteLine(" O valor de X2 é {0}:", x2);

            Console.ReadLine();
        }
    }
}
