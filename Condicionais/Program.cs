using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool chovendo = false;

            if (chovendo)
            {
                Console.WriteLine("Não esqueça o guarda-chuva");
            }
            else {
                Console.WriteLine("Não esqueça o óculos de sol");
            }*/ // 1º exemplo

            /*int n1 = 1, n2 = 10;

            if (n1 >= n2)
            {
                if(n1 == n2)
                {
                    Console.WriteLine("Os números são iguais");
                }
                Console.WriteLine($"O número {n1} é maior que {n2}");
            }
            else
            {
                Console.WriteLine($"O número {n2} é maior que {n1}");
            }*/ // 2º exemplo


            int n1, n2;

            Console.WriteLine("Digite um número");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= n2)
            {
                if (n1 == n2)
                {
                    Console.WriteLine("Os números são iguais");
                }
                else
                {
                    Console.WriteLine($"O número {n1} é maior que {n2}");
                }
            }
            else
            {
                Console.WriteLine($"O número {n2} é maior que {n1}");
            }
            

            Console.ReadKey(); 
        }
    }
}
