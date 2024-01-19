using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteadorAcme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa que sorteie um número aleatório. 
                Após isso o usuário pode informar com 3 tentativas um número para tentar adivinhar. 
                A cada suposição o sistema deve informar se o numero é menor ou maior que o sorteado. 
                Caso o usuário acerte deve ser mostrada uma mensagem de vitória, 
                caso ele não consiga deve ser mostrada a mensagem de derrota.
            */

            int tentativas = 0;
            // Sorteia um numero aleatório entre 1 e 30
            int numeroSorteado = new Random().Next(1, 30);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("====================================");
            Console.WriteLine("=   BEM VINDO AO MEGA SORTE 3000   =");
            Console.WriteLine("====================================");

            Console.WriteLine("Você possui 3 tentativas para acertar o número.");

            novaTentativa(numeroSorteado, 1);
            novaTentativa(numeroSorteado, 2);
            novaTentativa(numeroSorteado, 3);

            // Mostrar a mensagem de vitória
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("**         VOCÊ PERDEU!!!            **");
            Console.WriteLine("****************************************");
            Console.WriteLine("********Número**********Tentativas*********");
            Console.WriteLine($"**********{numeroSorteado}*************{tentativas}******");
            Console.WriteLine("****************************************");

            Console.ReadKey(true);
        }

        static void novaTentativa(int numeroSorteado, int tentativas)
        {
            Console.WriteLine("Qual seu terceiro palpite?");
            int palpite = int.Parse(Console.ReadLine());

            if (palpite == numeroSorteado)
            {
                // Mostrar a mensagem de vitória
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("****************************************");
                Console.WriteLine("****************************************");
                Console.WriteLine("**         VOCÊ ACERTOU!!!            **");
                Console.WriteLine("****************************************");
                Console.WriteLine("********Número**********Tentativas*********");
                Console.WriteLine($"**********{numeroSorteado}*************{tentativas}******");
                Console.WriteLine("****************************************");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                // Verifica se é maior ou menor
                if (palpite > numeroSorteado)
                {
                    Console.WriteLine("Seu palpite é MAIOR que o número sorteado!");
                }
                else
                {
                    Console.WriteLine("Seu palpite é MENOR que o número sorteado!");
                }
            }
        }
    }
}
