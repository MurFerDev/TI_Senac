using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    internal class Animal
    {
        // Atributos protegidos - Só são acessíveis dentro da classe
        protected string Nome; // Nome do animal
        protected int Idade; // Idade do animal

        // Propriedade pública para armazenar o que o animal come
        public string Alimento { get; private set; }

        // Construtor para inicializar os atributos
        public Animal(string nome, int idade, string alimento)
        {
            // Validações para garantir que os valores fornecidos sejam válidos
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do animal não pode ser vazio ou nulo.");
            }

            if (idade < 0) // Idade não pode ser negativa
            {
                throw new ArgumentException("A idade do animal não pode ser negativa.");
            }

            if (string.IsNullOrWhiteSpace(alimento)) // alimento não pode ser vazio ou nulo
            {
                throw new ArgumentException("O alimento não pode ser vazio ou nulo.");
            }

            // Atributos são inicializados se os valores forem válidos

            Nome = nome;
            Idade = idade;
            Alimento = alimento;

        }

        public virtual string Descrever()
        {
            return $"Animal: {Nome}, idade: {Idade} anos. ";
        }

    }
}
