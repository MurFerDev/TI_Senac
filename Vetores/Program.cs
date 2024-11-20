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
            Console.WriteLine(numeros[3]); // acessa o elemento 3

            numeros[3] = 34; // modificando o valor do elemento 3
            Console.WriteLine(numeros[3]); // acessa o elemento 3

            string[] frutas = { "Maçã", "Laranja", "Banana", "Uva" };
            Console.WriteLine($"A primeira fruta é: " + frutas[0]);

            Console.ReadKey();
        }
    }
}