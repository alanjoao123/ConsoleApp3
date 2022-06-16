using System;
using System.Collections.Generic;
using ConsoleApp3.Questoes._1;
using ConsoleApp3.Questoes._10;
using ConsoleApp3.Questoes._11;
using ConsoleApp3.Questoes._12;
using ConsoleApp3.Questoes._13;
using ConsoleApp3.Questoes._14;
using ConsoleApp3.Questoes._15;
using ConsoleApp3.Questoes._16;
using ConsoleApp3.Questoes._17;
using ConsoleApp3.Questoes._18;
using ConsoleApp3.Questoes._19;
using ConsoleApp3.Questoes._2;
using ConsoleApp3.Questoes._20;
using ConsoleApp3.Questoes._21;
using ConsoleApp3.Questoes._3;
using ConsoleApp3.Questoes._4;
using ConsoleApp3.Questoes._5;
using ConsoleApp3.Questoes._6;
using ConsoleApp3.Questoes._7;
using ConsoleApp3.Questoes._8;
using ConsoleApp3.Questoes._9;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(" Qual o execicio você quer abrir ?");
                    var opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Questao1.HelloWorld();
                            break;
                        case 2:
                            Questao2.QualSeuNNome();
                            break;
                        case 3:
                            Questao3.CaslcularSalario();
                            break;
                        case 4:
                            Questao4.Soma();
                            break;
                        case 5:
                            Questao5.MediaDaNota();
                            break;
                        case 6:
                            Questao6.AntecessorESucessor();
                            break;
                        case 7:
                            Questao7.Dobro();
                            break;
                        case 8:
                            Questao8.Quilometragem();
                            break;
                        case 9:
                            Questao9.Dollar();
                            break;
                        case 10:
                            Questao10.Parede();
                            break;
                        case 11:
                            Questao11.EquacaoSegundoGrau();
                            break;
                        case 12:
                            Questao12.CalcularDesconto();
                            break;
                        case 13:
                            Questao13.AumentoSalario();
                            break;
                        case 14:
                            Questao14.CalculaValorAluguelCarro();
                            break;
                        case 15:
                            Questao15.CalculaSalarioPorHora();
                            break;
                        case 16:
                            Questao16.CalculaDiasAMenos();
                            break;
                        case 17:
                            Questao17.CalculaValorMulta();
                            break;
                        case 18:
                            Questao18.VotoObrigatorio();
                            break;
                        case 19:
                            Questao19.SituacaoDoAluno();
                            break;
                        case 20:
                            Questao20.ParOuImpar();
                            break;
                        case 21:
                            Questao21.
                            break;
                        default:
                            Calculadora.Calcular();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}.");
                    Console.ReadKey();
                }               

                Console.Clear();
            }
        }
    }
}
