using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioListaDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            Console.WriteLine("Escolha uma das opções: \n1: Adicionar tarefa\n2: Remover tarefa\n3: Listar todas as tarefas\n4: Sair");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite uma nova tarefa: ");
                    lista.Add(Console.ReadLine());

                    Console.WriteLine("Deseja adicionar outra tarefa?: 1 - Sim \n2 - Não");
                    int novaTarefa = int.Parse(Console.ReadLine());

                    if (novaTarefa == 1)
                    {
                        do
                        {
                            Console.WriteLine("Digite a tarefa a ser removida: ");
                            lista.Add(Console.ReadLine());
                        }
                        while (novaTarefa == 1);
                    }
                    break;

                case 2:
                    Console.WriteLine("Digite a tarefa que deseja remover: ");
                    lista.Remove(Console.ReadLine());
                    break;

                case 3:
                    Console.WriteLine("Lista de tarefas:");

                    foreach (var tarefa in lista)
                    {
                        Console.WriteLine(lista + "\n");
                    }
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Saindo da lista de tarefas");
                    Thread.Sleep(400);
                    Console.Clear();
                    Console.WriteLine("Saindo da lista de tarefas .");
                    Thread.Sleep(400);
                    Console.Clear();
                    Console.WriteLine("Saindo da lista de tarefas ..");
                    Thread.Sleep(400);
                    Console.Clear();
                    Console.WriteLine("Saindo da lista de tarefas ...");
                    Thread.Sleep(400);
                    Console.Clear();
                    break;
                default:
                    Console.Write("Opção inválida!");
                    break;
            }

            Console.ReadKey();


        }
    }
}
