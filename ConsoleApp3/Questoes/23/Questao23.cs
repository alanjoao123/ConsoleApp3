﻿using System;


namespace ConsoleApp3.Questoes._23
{
    public class Questao23
    {
        public static void Diadamulher()
        {
            
            try
            {
                string nome;
                int sexo;
                float valorcomp, desconto1, desconto2;

                Console.WriteLine(" Qual o seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine(" {0} Qual seu sexo? ", nome);

                Console.WriteLine(" [1] Masculino");
                Console.WriteLine(" [2] Feminino ");
                sexo = int.Parse(Console.ReadLine());

                Console.WriteLine(" Qual o valor da Roupa: ");
                valorcomp = int.Parse(Console.ReadLine());

                if (1 == sexo)
                {
                    desconto1 = valorcomp - (valorcomp * 5 / 100);
                    Console.WriteLine("Você é Homem , mas, ganhou desconto. Seu valor ficou R$ {0} Reis.", desconto1);
                    
                }
                else if (2 == sexo)
                {
                    desconto2 = valorcomp - (valorcomp * 13 / 100);
                    Console.WriteLine(" Feliz dia da mulher!! Você ganhou desconto, Seu valor ficou de R$ {0} Reais.", desconto2);
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
