using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("---------- Tabela Dinâmica ----------\n");
            Console.Write("Digite um número para ver sua tabuada: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("O resultado de {0} x 0 é: {1}", numero, numero * 0);
            Console.WriteLine("O resultado de {0} x 1 é: {1}", numero, numero * 1);
            Console.WriteLine("O resultado de {0} x 2 é: {1}", numero, numero * 2);
            Console.WriteLine("O resultado de {0} x 3 é: {1}", numero, numero * 3);
            Console.WriteLine("O resultado de {0} x 4 é: {1}", numero, numero * 4);
            Console.WriteLine("O resultado de {0} x 5 é: {1}", numero, numero * 5);
            Console.WriteLine("O resultado de {0} x 6 é: {1}", numero, numero * 6);
            Console.WriteLine("O resultado de {0} x 7 é: {1}", numero, numero * 7);
            Console.WriteLine("O resultado de {0} x 8 é: {1}", numero, numero * 8);
            Console.WriteLine("O resultado de {0} x 9 é: {1}", numero, numero * 9);
            Console.WriteLine("O resultado de {0} x 10 é: {1}", numero, numero * 10);

            Console.ReadKey();
        }
    }
}
