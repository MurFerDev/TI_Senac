using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_JogoDePersonagens
{
    internal class Mago : Personagem
    {
        // Construtor
        public Mago(string nome, int vida) : base(nome, vida) { }

        // Sobrescrevendo o método Atacar
        public override void Atacar()
        {
            Console.WriteLine($"{Nome} lançou uma magia destruidora.");
        }
    }
}
