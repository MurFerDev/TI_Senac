using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PerguntasRespostas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] perguntas =
                {
                "Qual é o ano de descobrimento do Brasil ?",
                "Qual foi a 1ª Capital do Brasil ?",
                "Qual o nome do imperador do Brasil durante o período imperial?",
                "Quem foi o 1º Presidente do Brasil?",
                "Em que ano o Brasil se tornou independente de Portugal?"
                };
            string[] respostas =
            {
                "1500",
                "Salvador",
                "Dom Pedro II",
                "Marechal Deodoro da Fonseca",
                "1822"
            };

            while (true)
            {
                int acertos = 0;
                Console.WriteLine("QUEM QUER DINHEIROOO?");

                for (int i = 0; i < perguntas.Length; i++)
                {
                    Console.WriteLine(perguntas[i]);
                    string respostaJogador = Console.ReadLine();

                    if (respostaJogador.Equals(respostas[i], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Resposta correta.");
                        acertos++;
                    }
                    else
                    {
                        Console.WriteLine("Resposta errada.");
                    }
                    
                }
                
                if (acertos == 5)
                {
                    Console.WriteLine("\nVocê é fera, acertou todas as respostas!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Você acertou: {acertos} de {perguntas.Length} perguntas.");

                    Console.WriteLine("Deseja jogar novamente? (S/N)");
                    string jogarNovamente = Console.ReadLine();

                    if (jogarNovamente.ToUpper() == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }

            Console.WriteLine("Obrigado por jogar!");
            Console.ReadKey();
        }
    }
}
