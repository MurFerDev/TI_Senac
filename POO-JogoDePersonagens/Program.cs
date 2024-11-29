using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_JogoDePersonagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando instância de Guerreiro e Mago
            Personagem guerreiro = new Guerreiro("Jin", 100);
            Personagem mago = new Mago("Marvin", 80);

            //Mostrar vida dos Personagens
            guerreiro.MostrarVida();
            mago.MostrarVida();

            //Atacar com cada personegem
            guerreiro.Atacar();
            mago.Atacar();

            // Modificar ida e mostrar
            guerreiro.vida -= 30;
            mago.vida -= 20;

            guerreiro.MostrarVida();
            mago.MostrarVida();

            // Tentar configurar vida negativa
            mago.vida = -50;
            mago.MostrarVida();

            Console.ReadKey();

        }
    }
}
