using System;

namespace ConsoleApp3.Questoes._8
{
    public class Questao8
    {
        public static void Quilometragem()
        {
            float km, hm, dam, metro, dm, cm, mm;

            Console.Write(" Digite uma distancia em Metros: ");
            metro = float.Parse(Console.ReadLine());
            km = metro / 1000;
            hm = metro / 100;
            dam = metro / 10;
            dm = metro * 10;
            cm = metro * 100;
            mm = metro * 1000;

            Console.WriteLine(" A Distancia de " + metro + "Metros coresponde a : ");
            Console.WriteLine(" KILOMETROS:" + km);
            Console.WriteLine(" HECTÔMETRO:" + hm);
            Console.WriteLine(" DECÂMETRO:" + dam);
            Console.WriteLine(" DECIMETRO:" + dm);
            Console.WriteLine(" CENTÍMETRO:" + cm);
            Console.WriteLine(" MILIMETRO:" + mm);



            Console.ReadLine();
        }
    }
}
