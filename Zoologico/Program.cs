using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista para armazenar os animais do zoológico
            List<Animal> zoologico = new List<Animal>();

            try
            {
                // Criar e adicionar animais ao zoológico
                zoologico.Add(new Mamifero("Leão Scar", 5, "Carne"));
                zoologico.Add(new Ave("Arara Blue", 1, "Frutas", true));
                zoologico.Add(new Reptil("Jacaré Wally", 18, "Peixe", false));
                zoologico.Add(new Reptil("Cascavel Celeste", 3, "Insetos e roedores", true));
            }
            catch(ArgumentException ex)
            {
                // Captura e exibe a mensagem de erro para entradas inválidas
                Console.WriteLine($"Erro ao criar um animal: {ex.Message}");

            }

            // Exibe as informações osbre os animais que foram adicionados
            Console.WriteLine("\nRelatório de animais no Zoológico: ");

            foreach(Animal animal in zoologico)
            {
                Console.WriteLine(animal.Descrever());
                Console.WriteLine($"Se alimenta de: {animal.Alimento}\n");
            }

            Console.WriteLine("Fim do programa");
            Console.ReadKey();
        }
    }
}
