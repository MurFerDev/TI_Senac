using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores___Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            Console.Write("Digite um número inteiro: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1º número: {numeros[0]}\n");

            Console.Write("Digite um número inteiro: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"2º número: {numeros[1]}\n");

            Console.Write("Digite um número inteiro: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"3º número: {numeros[2]}\n");

            Console.Write("Digite um número inteiro: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"4º número: {numeros[3]}\n");

            Console.Write("Digite um número inteiro: ");
            numeros[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"5º número: {numeros[4]}\n");

            int maior = numeros[0];
            if (numeros[1] > numeros[0]) { maior = numeros[1]; }
            if (numeros[2] > maior) { maior = numeros[2]; }
            if (numeros[3] > maior) { maior = numeros[3]; }
            if (numeros[4] > maior) { maior = numeros[4]; }

            //Console.Write($"O maior valor é: {numeros.Max()}\n");
            //Console.Write($"O menor valor é: {numeros.Min()}\n");
            //Console.Write($"A soma dos valores é: {numeros.Sum()}\n");


            Console.ReadKey();
        }
    }
}
