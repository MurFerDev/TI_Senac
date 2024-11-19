using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inicialização com valores
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };

            // inicialização de um valor inteiro com 7 posições
            int[] notas = new int[7];

            Console.WriteLine(numeros[3]);

            Console.ReadKey();

        }
    }
}
