using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace While_Desafio_Bilheteria_Estadio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int capacidadeMaxima = 50000;
            int quantidadeIngressos, quantidadeTorcedoresFila, ingressosVendidos=0;
            double precoIngresso, arrecadacao;

            Console.WriteLine("*** VENDA DE INGRESSOS ***");
            
            Console.Write("Preço atual do ingresso: R$ ");
            //precoIngresso = Convert.ToInt32(Console.ReadLine());
            precoIngresso = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Quantidade de ingressos: ");
            //quantidadeIngressos = Convert.ToInt32(Console.ReadLine());
            quantidadeIngressos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Quantidade de torcedores na fila: ");
            //quantidadeTorcedoresFila = Convert.ToInt32(Console.ReadLine());
            quantidadeTorcedoresFila = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (capacidadeMaxima >= quantidadeIngressos)
            {
                while (quantidadeIngressos > 0 && quantidadeTorcedoresFila > 0)
                {
                    quantidadeIngressos--;
                    ingressosVendidos++;
                    quantidadeTorcedoresFila--;
                    Console.WriteLine($"Ingresso vendido! Total de ingressos vendidos {0}." +
                        $"Total de torcedores na fila: {1}", ingressosVendidos, quantidadeTorcedoresFila);
                }
                Console.WriteLine();

                arrecadacao = ingressosVendidos * precoIngresso;
                int ingressosRestantes = quantidadeIngressos - ingressosVendidos;

                Console.WriteLine($"Quantidade de torcedores restantes na fila: {quantidadeTorcedoresFila}");
                Console.WriteLine($"Total de ingressos vendidos: {ingressosVendidos}");
                Console.WriteLine($"Ingressos restantes: {ingressosRestantes}");
                Console.WriteLine($"Arrecadação total: R$ {arrecadacao}");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("A quantidade de ingressos é maior que a capacidade do estádio!");
            }

            Console.ReadKey();


             //Thread.Sleep(500);
        }
    }
}
