using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Lista_De_Tarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Caminho do arquivo do banco de dados
            string dbFile = "tarefas.db";

            // String de conexão com o banco de dados
            string connectionString = $"Data Source = {dbFile};Version=3;";

            // Verifica se o arquivo do DB já existe
            //Se não existe, ele cria o DB e as tabelas
            if (!File.Exists(dbFile))
            {
                // Cria um novo arquivo
                SQLiteConnection.CreateFile(dbFile);

                // Cria a tabela "tarefas" no DB.
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                    // Comando SQL para criar a tabela tarefas
                    string sql = "CREATE TABLE Tarefas" +
                        "(id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "Descricao TEXT NOT NULL)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery(); //Executa o comando
                    }
                    con.Close();
                }
            }


            //List<string> tarefas = new List<string>();
            int opcao;

            do
            {
                Console.WriteLine("\n Lista de Tarefas");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Remover Tarefa");
                Console.WriteLine("3 - Exibir Tarefas");
                Console.WriteLine("4 - Atualizar Tarefas");
                Console.WriteLine("5 - Limpar Console");
                Console.WriteLine("6 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a nova tarefa:");
                        string novaTarefa = Console.ReadLine();

                        // Insere a nova tarefa no DB
                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            con.Open();

                            // Comando SQL para inserir a nova tarefa
                            string sql_insert = "INSERT INTO Tarefas (Descricao)" +
                                "VALUES (@Descricao)";
                            using (SQLiteCommand cmd = new SQLiteCommand(sql_insert, con))
                            { 
                                cmd.Parameters.AddWithValue("@Descricao", novaTarefa);
                                cmd.ExecuteNonQuery();
                            } // Executa o comando SQL

                            con.Close();
                        }

                        Console.WriteLine("Sucesso! Tarefa adicionada");
                        break;

                    case 2:
                        Console.WriteLine("Digite a tarefa a ser removida:");

                        // Remove a tarefa no DB com base no id
                        int idRemover = Convert.ToInt32(Console.ReadLine());

                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            con.Open();

                            string sql_delete = "DELETE FROM Tarefas WHERE id = !id";
                            using (SQLiteCommand cmd = new SQLiteCommand(sql_delete, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idRemover);
                                int rownAffected = cmd.ExecuteNonQuery();

                                if (rownAffected > 0)
                                {
                                    Console.WriteLine("Tarefa removida com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Id não encontrado.\n");
                                }
                            }


                            con.Close();
                        }


                            //if (tarefas.Remove(tarefaRemover))
                            //{
                            //    Console.WriteLine("Tarefa removida com sucesso!");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Não foi possível remover");
                            //}
                        break;

                    case 3:
                        Console.WriteLine("Exibir Tarefas:\n");

                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            con.Open();

                            // Comando SQL para selecionar todas as tarefas
                            string sql_select = "SELECT * FROM Tarefas";
                            using (SQLiteCommand cmd = new SQLiteCommand(sql_select, con))
                            {
                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine($"ID: {reader["id"]} - Descricao: {reader["Descricao"]}");
                                    }
                                }
                            }

                            con.Close();
                        }
                        break;

                    case 4:
                        Console.Write("Digite o ID da Tarefa a ser atualizada: ");
                        int idAtualizar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a nova descrição da tarefa");
                        string novaDescricao = Console.ReadLine();

                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            con.Open();

                            string sql_update = "UPDATE Tarefas SET Descricao = @Descricao WHERE id = @id";
                            using (SQLiteCommand cmd = new SQLiteCommand(sql_update, con))
                            {
                                cmd.Parameters.AddWithValue("@Descricao", novaDescricao);
                                cmd.Parameters.AddWithValue("@id", idAtualizar);
                                int  rowsAffected = cmd.ExecuteNonQuery(); // Executa o comando

                                if(rowsAffected > 0)
                                {
                                    Console.WriteLine("tarefa atualizada com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Não foi possível atualizar. Id não encontrado!");
                                }
                            }

                            con.Close();
                        }
                        break;

                    case 5:
                        Console.WriteLine("Limpar Console");
                        Console.Clear();

                    case 6:
                        Console.WriteLine("Sair");

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 4);
        }
    }
}
