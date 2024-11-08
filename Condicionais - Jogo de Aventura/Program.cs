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
            int vida = 100, acao, escolha1, escolha2;
            bool espada = false, escudo = false;

            Console.WriteLine($"Você encontrou uma espada. \n" +
                $"Escoha uma opção: \n" +
                $"Pressione 1 -> Pegar espada \n" +
                $"Pressione 2 -> Ignorar espada ");
            escolha1 = Convert.ToInt32(Console.ReadLine());

            if(escolha1 == 1)
            {
                espada = true;
                Console.WriteLine("Você obteve: ESPADA");
            }
            else
            {
                espada = false;
            }
            Console.WriteLine("Continuando o jogo ...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Você encontrou um escudo. \n" +
            $"Escoha uma opção: \n" +
            $"Pressione 1 -> Pegar escudo \n" +
            $"Pressione 2 -> Ignorar escudo ");
            escolha2 = Convert.ToInt32(Console.ReadLine());

            if (escolha1 == 1)
            {
                escudo = true;
                Console.WriteLine("Você obteve: ESCUDO");
            }
            else
            {
                escudo = false;
            }
            Console.WriteLine("Continuando o jogo ...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Você encontrou um monstro! \nEscoha uma ação: \nPressione 1 -> Atacar \nPressione 2 -> Defender \n 3 -> Fugir ");
            acao = Convert.ToInt32(Console.ReadLine());

            if (acao == 1)
            {
                if (espada == true)
                {
                    Console.WriteLine($"Você atacou o monstro. \nPontos de vida: {vida}");
                }
                else
                {
                    vida -= 50;
                    Console.WriteLine($"Você atacou o monstro e perdeu 50 pontos de vida. \nPontos de vida: {vida}");
                }
            }
            else if (acao == 2)
            {
                if (escudo == true)
                {
                    vida -= 10;
                    Console.WriteLine($"Você de defendeu do ataque do monstro mas perdeu 10 pontos de vida. \nPontos de vida: {vida}");
                }

                if (acao == 3)
                {
                    Console.WriteLine($"Você fugiu do monstro. \nPontos de vida: {vida}");
                }
            }
            Console.ReadKey();
            
        }
    }
}
