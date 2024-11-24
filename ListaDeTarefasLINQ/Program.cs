using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioListaDeTarefas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Lista de Tarefas LINQ - C#";
            
            List<string> listaDeTarefas = new List<string>();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("1: Criar tarefa");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2: Remover tarefa");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("3: Listar todas as tarefas");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("4: Sair");
                Console.ResetColor();
                Console.Write("Opção: ");

                // Validação da entrada
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarTarefa(listaDeTarefas);
                        break;
                    case 2:
                        RemoverTarefa(listaDeTarefas);
                        break;
                    case 3:
                        ListarTarefas(listaDeTarefas);
                        break;
                    case 4:
                        Console.WriteLine("Saindo... Obrigado por usar o gerenciador de tarefas!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 4);
        }

        /// <summary>
        /// Adiciona uma nova tarefa à lista, garantindo que não haja duplicatas.
        /// </summary>
        /// <param name="lista">Lista de tarefas.</param>
        static void AdicionarTarefa(List<string> lista)
        {
            Console.Clear();
            Console.Write("Digite a nova tarefa: ");
            string novaTarefa = Console.ReadLine();

            // Verifica se a tarefa não está vazia e se não existe uma duplicata na lista
            if (!string.IsNullOrWhiteSpace(novaTarefa))
            {
                // Usando StringComparer.OrdinalIgnoreCase para garantir que a comparação seja insensível a maiúsculas/minúsculas
                if (lista.Contains(novaTarefa, StringComparer.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Esta tarefa já existe na lista.");
                    Console.ResetColor();
                }
                else
                {
                    lista.Add(novaTarefa);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("A tarefa não pode ser vazia.");
                Console.ResetColor();
            }

            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        /// <summary>
        /// Remove uma tarefa da lista com base na busca parcial ou no nome completo.
        /// </summary>
        /// <param name="lista">Lista de tarefas.</param>
        static void RemoverTarefa(List<string> lista)
        {
            Console.Clear();
            if (lista.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhuma tarefa para remover.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Tarefas atuais:");
                foreach (var tarefa in lista)
                {
                    Console.WriteLine($"- {tarefa}");
                }

                Console.Write("Digite parte ou o nome completo da tarefa que deseja remover: ");
                string busca = Console.ReadLine();

                var tarefasEncontradas = lista
                    .Where(t => t.Contains(busca))
                    .ToList();

                if (tarefasEncontradas.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Nenhuma tarefa encontrada com esse nome.");
                    Console.ResetColor();
                }
                else if (tarefasEncontradas.Count == 1)
                {
                    lista.Remove(tarefasEncontradas[0]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tarefa removida com sucesso!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Múltiplas tarefas encontradas:");
                    for (int i = 0; i < tarefasEncontradas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {tarefasEncontradas[i]}");
                    }

                    Console.Write("Escolha o número da tarefa que deseja remover: ");
                    if (int.TryParse(Console.ReadLine(), out int escolha) && escolha > 0 && escolha <= tarefasEncontradas.Count)
                    {
                        lista.Remove(tarefasEncontradas[escolha - 1]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tarefa removida com sucesso!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Escolha inválida.");
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        /// <summary>
        /// Lista todas as tarefas armazenadas.
        /// </summary>
        /// <param name="lista">Lista de tarefas.</param>
        static void ListarTarefas(List<string> lista)
        {
            Console.Clear();
            if (lista.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Lista de tarefas:");
                foreach (var tarefa in lista)
                {
                    Console.WriteLine($"- {tarefa}");
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
