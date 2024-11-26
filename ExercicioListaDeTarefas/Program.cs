using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SQlite;
using System.IO;

namespace ExercicioListaDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Caminho do arquivo do banco de dados
            string dbFile = "tarefas.db";

            // String de conexão com o banco de dados
            string conectionString = $"Data Source = {dbFile};Version=3;";

            // Verifica se o arquivo do DB já existe
            //Se não existe, ele cria o DB e as tabelas
            if (!File.Exists(dbFile))
            {
                // Cria um novo arquivo
                SQLiteConnection.CreateFile(dbFile);
            }



            Console.Title = "Lista de tarefas no C#";

            List<string> listaDeTarefas = new List<string>();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1: Criar tarefa");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2: Remover tarefa");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3: Listar todas as tarefas");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("4: Sair");
                Console.ResetColor();
                Console.Write("Opção: ");

                // Validação da entrada
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
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
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 4);
        }

        static void AdicionarTarefa(List<string> lista)
        {
            Console.Clear();
            Console.Write("Digite a nova tarefa: ");
            string novaTarefa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novaTarefa))
            {
                lista.Add(novaTarefa);
                Console.WriteLine("Tarefa adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("A tarefa não pode ser vazia.");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        static void RemoverTarefa(List<string> lista)
        {
            Console.Clear();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa para remover.");
            }
            else
            {
                Console.WriteLine("Tarefas atuais:");
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {lista[i]}");
                }

                Console.Write("Digite o número da tarefa que deseja remover: ");
                if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= lista.Count)
                {
                    lista.RemoveAt(indice - 1);
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        static void ListarTarefas(List<string> lista)
        {
            Console.Clear();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
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

