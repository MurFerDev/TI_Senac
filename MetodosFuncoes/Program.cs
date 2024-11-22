using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 -> Soma (+)\n2 -> Subtração (-)\n3 -> Multiplicação (*)\n4 -> Divisão (/)");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você escolheu Soma");
                    Console.WriteLine("O resultado da soma é: " + Somar(n1,n2));
                    break;
                case 2:
                    Console.WriteLine("Você escolheu Subtrair");
                    Console.WriteLine("O resultado da subtração é: " + Subtrair(n1, n2));
                    break;
                case 3:
                    Console.WriteLine("Você escolheu Multiplicar");
                    Console.WriteLine("O resultado da multiplicação é: " + Multiplicar(n1, n2));
                    break;
                case 4:
                    Console.WriteLine("Você escolheu Dividir");
                        Console.WriteLine("O resultado da divisão é: " + Dividir(n1, n2));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.ReadKey();
        }

        static int Somar(int a, int b)
        {  return a + b; }

        static int Subtrair(int a, int b)
        { return a - b; }

        static int Multiplicar(int a, int b)
        { return a * b; }

        static double Dividir(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / b;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero");
                return 0;
            }
        }
    }
}
