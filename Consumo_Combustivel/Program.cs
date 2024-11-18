using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace While__Consumo_de_Combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int capacidadeMaximaTanque = 150;
            int combustivel = 100; // Quantidade combustivel inicial
            int consumo = 5; // Consumo de combustível a cada ciclo
            int capacidadeReserva = 20; //Nível de alerta para abastecer

            Console.WriteLine("Você entrou no carro. Acelere para começar a dirigir: ");
            string escolha = Console.ReadLine().ToLower();

            if (escolha == "acelerar")
            {
                Console.WriteLine("O carro começou a se mover...");

                while (combustivel > 0)
                {
                    combustivel -= consumo; // Diminui o combustível
                    Console.Clear();

                    Console.WriteLine("Carro em movimento.\n Para parar digite (P).\n");
                    Console.WriteLine("Combustível restante {0}", combustivel);

                    if (combustivel <= capacidadeReserva && combustivel > 0)
                    {
                        Console.WriteLine("Alerta! Combustível esgotando.");
                        //Console.Beep(4000, 1000); //Hz e ms
                    }
                    if (combustivel <= 0)
                    {
                        Console.WriteLine("O combustível acabou! O carro parou...");
                        break;
                    }
                    // Pausa para simular o consumo contínuo
                    Thread.Sleep(500);

                    if (Console.KeyAvailable)
                    {
                        char tecla = Console.ReadKey(true).KeyChar;
                        if (char.ToUpper(tecla) == 'P')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Você parou o carro\nSimulação encerrada.");
                            Console.WriteLine("Combustível restante: {0}", combustivel);
                            break;
                        }
                        else if (char.ToUpper(tecla) == 'A')
                        {
                            if (combustivel <= capacidadeMaximaTanque)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Você parou para abastecer.");
                                Console.WriteLine("Abastecendo...");
                                Thread.Sleep(2000);
                                while (combustivel < capacidadeMaximaTanque)
                                {
                                    combustivel += 5;
                                    Console.WriteLine($"Combustível atual: {combustivel}");
                                    Thread.Sleep(250);

                                    if (combustivel == capacidadeMaximaTanque)
                                    {
                                        Console.WriteLine("Tanque completo!");
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ainda não é possível abastecer. Continuando a rota");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Simulação encerrada!");
            }

            Console.WriteLine("Fim da simulação.");
            Console.ReadKey();
        }
    }
}