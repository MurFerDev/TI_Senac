using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroTabuada, i = 0;

            Console.WriteLine("---------- Tabuada Dinâmica ----------");
            Console.WriteLine("Digite um número para ver sua tabuada: ");
            numeroTabuada = int.Parse(Console.ReadLine());

            while (i <= 10)
            {
                Console.WriteLine("o resultado de {0} x {1} é: {2}", numeroTabuada, i, numeroTabuada * i);
                i++;
            }
        }
    }
}
