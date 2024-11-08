using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite a idade do usuário: ");
            idade = Convert.ToInt32(Console.ReadLine());

            //if (idade >= 18)
            //{
            //    Console.WriteLine("Você é maior de idade");
            //}
            //else
            //{
            //    Console.WriteLine("Você é menor de idade");
            //}

            if (idade >= 60)
            {
                Console.WriteLine("O ususário é um idoso.");
            }
            else if(idade >= 18)
            {
                Console.WriteLine("O ususário é um adulto.");
            }
            else if (idade >= 12)
            {
                Console.WriteLine("O ususário é um adolescente.");
            }
            else
            {
                Console.WriteLine("O usuário é uma criança.");
            }

            Console.ReadKey();
        }
    }
}