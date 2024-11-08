using System;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno, chance;
            double media, nota1, nota2, nota3, nota4;

            Console.Write("Nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Digite a 1ª nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 2ª nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 3ª nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 4ª nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.Clear();

            if (media >= 7)
            {
                Console.WriteLine($"Aluno: {nomeAluno}\n" +
                    $"Média Final: {media}. Aprovado!");
            }
            else if (media >= 6 || media <= 6.9)
            {
                Console.WriteLine("O Aluno merece uma chance? Digite: Sim para aprová-lo ou Não para recuperação.");
                chance = Console.ReadLine();

                if (chance == "Sim" || chance == "sim" || chance == "SIM")
                {
                    media += 1;
                    Console.WriteLine($"Aluno: {nomeAluno}\n" +
                        $"Média Final: {media}. Aprovado!");
                }
                else
                {
                    Console.WriteLine($"Aluno: {nomeAluno}\n" +
                        $"Média Final: {media}. Recuperação!");
                }
            }
            else if (media >= 5 || media < 6)
            {
                Console.WriteLine($"Aluno: {nomeAluno}\n" +
                    $"Média Final: {media}. Recuperação!");
            }
            else
            {
                Console.WriteLine($"Aluno: {nomeAluno}\n" +
                    $"Média Final: {media}. Reprovado!");
            }

            Console.ReadKey();
        }
    }
}
