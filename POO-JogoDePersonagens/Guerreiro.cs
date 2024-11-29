using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_JogoDePersonagens
{
    class Guerreiro : Personagem
    {
        // Construtor: Cria uma instância de Guerreiro e garante os valores iniciais de nome e vida
        public Guerreiro(string nome, int vida) : base(nome, vida) { }
        // Base: chama o construtor da Classe Personagem, passando os parãmetro de nome e vida.
        // O Guerreiro herda essas propriedades se precisar redefini-las na classe pai.


        public override void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com sua espada lendária!");
            // Modificamos o comportamento do método.
            // Qualque instância de Guerreiro vai usar esse novo comportamento.
        }
    }
}
