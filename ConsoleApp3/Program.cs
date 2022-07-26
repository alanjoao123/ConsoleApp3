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
using ConsoleApp3.Questoes._22;
using ConsoleApp3.Questoes._23;
using ConsoleApp3.Questoes._24;
using ConsoleApp3.Questoes._25;
using ConsoleApp3.Questoes._26;
using ConsoleApp3.Questoes._27;
using ConsoleApp3.Questoes._28;
using ConsoleApp3.Questoes._29;
using ConsoleApp3.Questoes._3;
using ConsoleApp3.Questoes._30;
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
                    Console.WriteLine(" 1 -  Hello World");
                    Console.WriteLine(" 2 -  Qual seu nome");
                    Console.WriteLine(" 3 -  Calcular Salário");
                    Console.WriteLine(" 4 -  Soma");
                    Console.WriteLine(" 5 -  MediaDaNota");
                    Console.WriteLine(" 6 -  AntecessorESucessor");
                    Console.WriteLine(" 7 -  Dobro");
                    Console.WriteLine(" 8 -  Quilometragem");
                    Console.WriteLine(" 9 -  Dollar");
                    Console.WriteLine(" 10 - Parede");
                    Console.WriteLine(" 11 - EquacaoSegundoGrau");
                    Console.WriteLine(" 12 - CalcularDesconto");
                    Console.WriteLine(" 13 - AumentoSalario");
                    Console.WriteLine(" 14 - CalculaValorAluguelCarro");
                    Console.WriteLine(" 15 - CalculaSalarioPorHora");
                    Console.WriteLine(" 16 - CalculaDiasAMenos");
                    Console.WriteLine(" 17 - CalculaValorMulta");
                    Console.WriteLine(" 18 - VotoObrigatorio");
                    Console.WriteLine(" 19 - SituacaoDoAluno");
                    Console.WriteLine(" 20 - ParOuImpar");
                    Console.WriteLine(" 21 - AnoBissexto");
                    Console.WriteLine(" 22 - Alistamento");
                    Console.WriteLine(" 23 - Diadamulher");
                    Console.WriteLine(" 24 - Passageiro");
                    Console.WriteLine(" 25 - Triângulos");
                    Console.WriteLine(" 26 - ComparadorNumeros");
                    Console.WriteLine(" 27 - MediaAluno");
                    Console.WriteLine(" 28 - MedidasTerreno");
                    Console.WriteLine(" 29 - ReajusteSalario");
                    Console.WriteLine(" 30 - TipoTriangulo");

                    Console.WriteLine(" ");
                    Console.WriteLine(" Digite a opção desejada: ");
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
                            Questao21.AnoBissexto();
                            break;
                        case 22:
                            Questao22.Alistamento();
                            break;
                        case 23:
                            Questao23.Diadamulher();
                            break;
                        case 24:
                            Questao24.Passageiro();
                            break;
                        case 25:
                            Questao25.Triângulos();
                            break;
                        case 26:
                            Questao26.ComparadorNumeros();
                            break;
                        case 27:
                            Questao27.MediaAluno();
                            break;
                        case 28:
                            Questao28.MedidasTerreno();
                            break;
                        case 29:
                            Questao29.ReajusteSalario();
                            break;
                        case 30:
                            Questao30.TipoTriangulo();
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
