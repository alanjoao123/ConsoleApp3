using System;

namespace ConsoleApp3.Questoes._10
{
    public class Questao10
    {
        public static void Parede()
        {
            float larg, alt, area, tinta;

            Console.Write(" Informe a largura da parede : ");
            larg = float.Parse(Console.ReadLine());
            Console.Write(" Informe a altura da parede: ");
            alt = float.Parse(Console.ReadLine());
            area = larg * alt;
            Console.WriteLine(" Sua parede tem a dimensão de: " + area + "m²");
            tinta = area / 2;
            Console.WriteLine(" Para pintar sua parede, você precisara de " + tinta + "L de tintas ");
            Console.ReadKey();
        }
    }
}
