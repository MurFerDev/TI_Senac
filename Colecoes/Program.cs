using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* // *** EXEMPLO DE LISTA *** 
            List<string> nomes = new List<string>();

            nomes.Add("Cecília");
            nomes.Add("Alice");
            nomes.Add("Mariana");

            Console.WriteLine("Nomes na lista: ");

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            */

            /* // *** EXEMPLO DE COLEÇÃO ***
            HashSet<int> numeros = new HashSet<int>();

            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(10);

            Console.WriteLine("Números no conjunto: ");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */

            // *** EXEMPLO DE MAPA / DICIONÁRIO ***
            Dictionary<string, int> idades = new Dictionary<string, int>();

            idades.Add("Enrico", 5);
            idades.Add("Cecília", 5);
            idades.Add("Alice", 3);
            idades.Add("Mariana", 2);

            Console.WriteLine("Idades: ");

            foreach (var par in idades)
            {
                Console.WriteLine($"Nome: {par.Key}, {par.Value} anos");
            }

            Console.ReadKey();

        }
    }
}
