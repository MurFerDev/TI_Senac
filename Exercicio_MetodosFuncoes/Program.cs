using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_MetodosFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirMenu();

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    int qtd = ObterQuantidade();
                    double valor = CalcularHamburger(qtd);
                    Console.Write("Total: R$ " + valor);
                    break;
                case 2:
                    qtd = ObterQuantidade();
                    valor = CalcularBatata(qtd);
                    Console.Write("Total: R$ " + valor);
                    break;
                case 3:
                    qtd = ObterQuantidade();
                    valor = CalcularRefrigerante(qtd);
                    Console.Write("Total: R$ " + valor);
                    break;
                case 4:
                    qtd = ObterQuantidade();
                    valor = CalcularSobremesa(qtd);
                    Console.Write("Total: R$ " + valor);
                    break;
                default:
                    Console.Write("");
                    break;
            }

            Console.ReadKey();
        }

        static void ExibirMenu()
        {
            Console.WriteLine("Confira nosso cardápio:");
            Console.WriteLine("1 - Hamburger    (R$ 25,00)");
            Console.WriteLine("2 - Batata Frita (R$ 7,00)");
            Console.WriteLine("3 - Refrigerante (R$ 8,00)");
            Console.WriteLine("4 - Sobremesa    (R$ 14,00)");
        }

        static int ObterQuantidade()
        {
            Console.Write("Digite a quantidade: ");
            return int.Parse(Console.ReadLine());
        }

        static double CalcularHamburger(int quantidade)
        { return quantidade * 25.00; }

        static double CalcularBatata(int quantidade)
        { return quantidade * 7.00; }

        static double CalcularRefrigerante(int quantidade)
        { return quantidade * 8.00; }

        static double CalcularSobremesa(int quantidade)
        { return quantidade * 14.00; }

    }
}
