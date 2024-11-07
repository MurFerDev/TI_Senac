using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais___Jogo_de_Aventura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vida = 100, acao, escolha;
            bool espada = false;

            Console.WriteLine("Você encontrou uma espada. \nEscoha uma opção: \nPressione 1 -> Pegar espada \nPressione 2 -> Ignorar espada ");
            escolha = Convert.ToInt32(Console.ReadLine());

            if(escolha == 1)
            {
                espada = true;
            }
            else
            {
                espada = false;
            }

            Console.WriteLine("Você encontrou um monstro! \nEscoha uma ação: \nPressione 1 -> Atacar \nPressione 2 -> Fugir ");
            acao = Convert.ToInt32(Console.ReadLine());

            if (acao == 1)
            {
                if (espada == true)
                {
                    Console.WriteLine($"Você atacou o monstro. \nPontos de vida: {vida}");
                }
                else
                {
                    vida -= 30;
                    Console.WriteLine($"Você atacou o monstro e perdeu 30 pontos de vida. \nPontos de vida: {vida}");
                }
            }

            if(acao == 2)
            {
                Console.WriteLine($"Você fugiu do monstro. \nPontos de vida: {vida}");
            }
            //else
            //{
            //    Console.WriteLine($"Opção inválida, tente novamente!");
            //}

            Console.ReadKey(); 
            
        }
    }
}
