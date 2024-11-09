using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BilheteriaTeatro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade, opcaoPagamento;
            double valorIngresso, carteira = 50;

            Console.Write("Insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            //if (idade >= 60)
            //{
            //    Console.WriteLine("Ingresso idoso: R$14,90");
            //}
            //else if (idade >= 12 && idade <= 59)
            //{
            //    Console.WriteLine("Ingresso comum: R$29,90");
            //}
            //else
            //{
            //    Console.WriteLine("Ingresso infantil: R$9,90");
            //}

            if (idade >= 60)
            {
                valorIngresso = 14.90;
            }
            else if (idade >= 12 && idade <= 59)
            {
                valorIngresso = 29.90;
            }
            else
            {
                valorIngresso = 9.90;
            }

            Console.WriteLine($"Valor do ingresso: R${valorIngresso}\n");

            Console.WriteLine($"Deseja prosseguir com o pagamento?" +
                $"\n1 - Pagar ingresso\t2 - Cancelar compra");
            opcaoPagamento = Convert.ToInt32(Console.ReadLine());

            if (opcaoPagamento == 1)
            {
                if (carteira == valorIngresso)
                {
                    Console.WriteLine($"Compra realizada com sucesso." +
                        $"\nVocê tem 1 ingresso!");
                }
                else if (carteira >= valorIngresso)
                {
                    Console.WriteLine($"Compra realizada com sucesso." +
                        $"\nVocê tem 1 ingresso! \nTroco: R${carteira - valorIngresso}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente. Sua compra foi cancelada.");
                }
            }
            else if (opcaoPagamento == 2)
            {
                Console.WriteLine("Compra cancelada!");
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente!");
            }


            Console.ReadKey();
        }
    }
}
